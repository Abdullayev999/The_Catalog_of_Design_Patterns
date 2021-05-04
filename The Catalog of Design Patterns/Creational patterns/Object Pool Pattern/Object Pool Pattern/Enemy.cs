namespace Object_Pool_Pattern
{
    class Enemy
    {
        private static int count = 0;

        public Enemy()
        {
            Name = (++count).ToString();
        }

        public string Name { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
    }
}
