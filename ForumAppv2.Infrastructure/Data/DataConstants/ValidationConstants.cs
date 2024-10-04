namespace ForumAppv2.Infrastructure.Data.DataConstants
{
    public static class ValidationConstants
    {
        public const int PostTitleMinLength = 10;
        public const int PostTitleMaxLength = 50;

        public const int PostContentMinLength = 30;
        public const int PostContentMaxLength = 1500;

        public const string RequiredWarning = "Field {0} is required!";
        public const string LengthWarning = "Field {0} must be between {2} and {1} characters long!";
    }
}
