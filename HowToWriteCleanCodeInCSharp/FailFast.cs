using System;

namespace HowToWriteCleanCodeInCSharp
{
    class FailFast
    {
        public bool SlowFail()
        {
            var isRightAge = true;
            var isRightSize = true;
            var isRightPerson = true;

            if (isRightAge)
            {
                if (isRightSize)
                {
                    if (isRightPerson)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public bool FastFail()
        {
            var isRightAge = true;
            var isRightSize = true;
            var isRightPerson = true;

            if (!isRightAge) return false;
            if (!isRightSize) return false;
            if (!isRightPerson) return false;

            return true;
        }

        public int? SlowFailInLoop()
        {
            var random = new Random();
            int i = random.Next(0, 100);

            while (true)
            {
                if (i >= 20)
                {
                    if (i <= 80)
                    {
                        if (i.GetHashCode() != 0)
                        {
                            return i;
                        }
                    }
                }
            }
        }

        public int? FastFailInLoop()
        {
            var random = new Random();
            int i = random.Next(0, 100);

            while (true)
            {
                if (i < 20) continue;
                if (i > 80) continue;
                if (i.GetHashCode() != 0) return i;
            }
        }


    }
}
