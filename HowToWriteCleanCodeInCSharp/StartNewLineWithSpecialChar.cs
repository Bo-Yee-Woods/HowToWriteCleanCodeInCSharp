namespace HowToWriteCleanCodeInCSharp
{
    class StartNewLineWithSpecialChar
    {
        public string UglyMultiLineOfString()
        {
            return "Follow standard conventions " +
                "Keep it simple stupid. Simpler is always better. Reduce complexity as much as possible " +
                "Boy scout rule. Leave the campground cleaner than you found it " +
                "Always find root cause. Always look for the root cause of a problem ";
        }

        public string PrettyMultiLineOfString()
        {
            return "Follow standard conventions "
                 + "Keep it simple stupid. Simpler is always better. Reduce complexity as much as possible "
                 + "Boy scout rule. Leave the campground cleaner than you found it "
                 + "Always find root cause. Always look for the root cause of a problem ";
        }

        public bool UglyMultiLineOfBool()
        {
            return 1 + 1 == 2 &&
                1 + 2 == 3 &&
                1 + 3 == 4 &&
                1 + 4 == 5;
        }

        public bool PrettyMultiLineOfBool()
        {
            return 1 + 1 == 2
                && 1 + 2 == 3
                && 1 + 3 == 4
                && 1 + 4 == 5;
        }

        public string UglyMultiLineOfSelection()
        {
            return 1 + 1 == 2 ?
                "one plus one equal two" :
                "one plus one not equal two";
        }

        public string PrettyMultiLineOfSelection()
        {
            return 1 + 1 == 2
                ? "one plus one equal two"
                : "one plus one not equal two";
        }
    }
}
