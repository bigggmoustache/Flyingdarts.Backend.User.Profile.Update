﻿using FluentValidation;

public class UpdateUserProfileCommandValidator : AbstractValidator<UpdateUserProfileCommand>
{
    public UpdateUserProfileCommandValidator()
    {
        RuleFor(x => x.CognitoUserId)
                        .Must(x => x.Contains("facebook"));

        RuleFor(x => x.UserName)
            .MinimumLength(2)
            .MaximumLength(32);

        RuleFor(x => x.Email)
            .EmailAddress();

        RuleFor(x => x.Country)
            .MinimumLength(2)
            .MaximumLength(3);
    }
}