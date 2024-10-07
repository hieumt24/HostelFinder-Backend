using HostelFinder.Application.DTOs.Auth.Requests;
using HostelFinder.Application.DTOs.Auth.Responses;
using HostelFinder.Application.DTOs.Auths.Requests;
using HostelFinder.Application.Interfaces.IRepositories;
using HostelFinder.Application.Interfaces.IServices;
using HostelFinder.Application.Wrappers;
using HostelFinder.Domain.Common.Constants;
using HostelFinder.Domain.Entities;
using HostelFinder.Infrastructure.Services.Interfaces;
using Microsoft.AspNetCore.Identity;

namespace HostelFinder.Application.Services
{
    public class AuthAccountService : IAuthAccountService
    {
        private readonly IUserRepository _userRepository;
        private readonly ITokenService _tokenService;
        private readonly IEmailService _emailService;
        private readonly PasswordHasher<User> _passwordHasher;

        public AuthAccountService(IUserRepository userRepository
            , ITokenService tokenService,
            IEmailService emailService
            )
        {
            _userRepository = userRepository;
            _tokenService = tokenService;
            _emailService = emailService;
            _passwordHasher = new PasswordHasher<User>();
        }

        public Task<Response<string>> ChangePasswordAsync(ChangePasswordRequest request)
        {
            throw new NotImplementedException();
        }

        public async Task<Response<string>> ForgotPasswordAsync(ForgotPasswordRequest request)
        {
            var user = await _userRepository.FindByEmailAsync(request.Email);
            if (user == null)
            {
                return new Response<string> { Succeeded = false, Message = "Email không tồn tại. Vui lòng kiểm tra hoặc tạo tài khoản mới." };
            }
            var resetToken = await _tokenService.GenerateResetPasswordToken(user);

            var emailBody = EmailConstants.BodyResetPasswordEmail(user.Email, resetToken);
            var emailSubject = "Đặt lại mật khẩu";

            await _emailService.SendEmailAsync(user.Email, emailSubject, emailBody);

            return new Response<string> { Succeeded = true, Message = "Link đặt lại mật khẩu đã được gửi tới email của bạn. Vui lòng check email!" };
        }

        public async Task<Response<AuthenticationResponse>> LoginAsync(AuthenticationRequest request)
        {
            var user = await _userRepository.FindByUserNameAsync(request.UserName);
            if (user == null)
            {
                return new Response<AuthenticationResponse> { Succeeded = false, Message = "Tên người dùng không tồn tại. Vui lòng kiểm tra hoặc tạo tài khoản mới." };
            }

            var verificationResult = _passwordHasher.VerifyHashedPassword(user, user.Password, request.Password);
            if (verificationResult == PasswordVerificationResult.Failed)
            {
                return new Response<AuthenticationResponse> { Succeeded = false, Message = "Tài khoản hoặc mật khẩu không đúng. Vui lòng kiểm tra lại!" };
            }

            var role = await _userRepository.GetRoleAsync(user.Id);
            var token = _tokenService.GenerateJwtToken(user, role);

            var response = new AuthenticationResponse
            {
                UserName = user.Username,
                Role = role.ToString(),
                Token = token
            };

            return new Response<AuthenticationResponse> { Data = response, Succeeded = true, Message = "Đăng nhập thành công" };
        }

        public async Task<Response<string>> ResetPasswordAsync(ResetPasswordRequest request)
        {
            var user = await _userRepository.FindByEmailAsync(request.Email);
            if (user == null)
            {
                return new Response<string> { Succeeded = false, Message = "Email không tồn tại. Vui lòng kiểm tra hoặc tạo tài khoản mới." };
            }

            var isValidToken = await _tokenService.ValidateResetPasswordToken(user, request.Token);
            if (!isValidToken)
            {
                return new Response<string> { Succeeded = false, Message = "Token không hợp lệ. Vui lòng check và thử lại" };
            }

            user.Password = _passwordHasher.HashPassword(user, request.NewPassword);

            user.PasswordResetToken = null;
            user.PasswordResetTokenExpires = null;

            await _userRepository.UpdateAsync(user);
            return new Response<string> { Succeeded = true, Message = "Đặt lại mật khẩu thành công!" };
        }
    }
}