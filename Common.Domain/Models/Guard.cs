namespace Common.Domain.Models
{
    using System;
    using Common.Domain;

    public static class Guard
    {
        public static void AgainstEmptyString<TException>(string value, string name = "Value")
            where TException : BaseDomainException, new()
        {
            if (!string.IsNullOrEmpty(value))
            {
                return;
            }

            ThrowException<TException>($"{name} cannot be null ot empty.");
        }

        public static void ForStringLength<TException>(string value, int minLength, int maxLength, string name = "Value")
            where TException : BaseDomainException, new()
        {
            AgainstEmptyString<TException>(value, name);

            if (minLength <= value.Length && value.Length <= maxLength)
            {
                return;
            }

            ThrowException<TException>($"{name} must have between {minLength} and {maxLength} symbols.");
        }

        public static void AgainstOutOfRange<TException>(int number, int min, int max, string name = "Value")
            where TException : BaseDomainException, new()
        {
            if (min <= number && number <= max)
            {
                return;
            }

            ThrowException<TException>($"{name} must be between {min} and {max}.");
        }

        public static void AgainstOutOfRange<TException>(decimal number, decimal min, decimal max, string name = "Value")
            where TException : BaseDomainException, new()
        {
            if (min <= number && number <= max)
            {
                return;
            }

            ThrowException<TException>($"{name} must be between {min} and {max}.");
        }

        public static void ForPositiveNumber<TException>(int number, string name = "Value")
            where TException : BaseDomainException, new()
        {
            if (number > 0)
            {
                return;
            }

            ThrowException<TException>($"{name} must be greater than 0.");
        }

        public static void ForPositiveNumber<TException>(double number, string name = "Value")
            where TException : BaseDomainException, new()
        {
            if (number > 0)
            {
                return;
            }

            ThrowException<TException>($"{name} must be greater than 0.");
        }

        public static void ForValidUrl<TException>(string url, string name = "Value")
            where TException : BaseDomainException, new()
        {
            if (url.Length <= ModelConstants.Common.MaxUrlLength &&
                Uri.IsWellFormedUriString(url, UriKind.Absolute))
            {
                return;
            }

            ThrowException<TException>($"{name} must be a valid URL.");
        }


        public static void Against<TException>(object actualValue, object unexpectedValue, string name = "Value")
            where TException : BaseDomainException, new()
        {
            if (!actualValue.Equals(unexpectedValue))
            {
                return;
            }

            ThrowException<TException>($"{name} must not be {unexpectedValue}.");
        }

        //public static void ForMatchesCount<TException>(HashSet<Match> matches, string name = "Value")
        //    where TException : BaseDomainException, new()
        //{
        //    if (name == nameof(RoundOf16))
        //    {
        //        if (matches.Count > 8)
        //        {
        //            ThrowException<TException>($"{name} must be greater than 0.");
        //        }
        //    }
        //    else if (name == nameof(QuarterFinals))
        //    {
        //        if (matches.Count > 4)
        //        {
        //            ThrowException<TException>($"{name} must be greater than 0.");
        //        }
        //    }
        //    else if (name == nameof(SemiFinals))
        //    {
        //        if (matches.Count > 2)
        //        {
        //            ThrowException<TException>($"{name} must be greater than 0.");
        //        }
        //    }

        //    return;
        //}

        private static void ThrowException<TException>(string message)
            where TException : BaseDomainException, new()
        {
            var exception = new TException
            {
                Message = message
            };

            throw exception;
        }
    }
}
