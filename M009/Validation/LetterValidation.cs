﻿using System.Globalization;
using System.Windows.Controls;

namespace M009.Validation;

public class LetterValidation : ValidationRule
{
	public override ValidationResult Validate(object value, CultureInfo cultureInfo)
	{
		string eingabe = (value as string)!;
		if (eingabe.All(char.IsLetter))
			return ValidationResult.ValidResult;

		return new ValidationResult(false, "Der Vorname darf nur aus Buchstaben bestehen!");
	}
}