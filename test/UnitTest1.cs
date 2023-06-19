using lab03_review;
namespace test
{
    public class UnitTest1
    {
        
        //challange1
        [Fact]
        public void challange1Test1()
        {
            string array = "1,4,5";
            int result = Program.product(array);
            Assert.Equal(result, 20);
        }
        [Fact]
        public void challange1Test2()
        {
            string array = "1,4,5,7";
            int result = Program.product(array);
            Assert.Equal(result, 20);
        }
        [Fact]
        public void challange1Test3()
        {
            string array = "1,4";
            int result = Program.product(array);
            Assert.Equal(result, 0);
        }
        [Fact]
        public void challange1Test4()
        {
            string array = "1,-4,5";
            int result = Program.product(array);
            Assert.Equal(result, -20);
        }


        //challange2
        [Fact]
        public void challange2Test1()
        {
            string[] array = { "4", "4", "5", "4", "5" };
            int result = Program.avarage(5, array);
            Assert.Equal(result, 4);
        }
        [Fact]
        public void challange2Test2()
        {
            string[] array = { "4", "2", "5", "a", "4" };
            int result = Program.avarage(5, array);
            Assert.Equal(result, -10);
        }
        [Fact]
        public void challange2Test3()
        {
            string[] array = { "0", "0", "0", "0", "0" };
            int result = Program.avarage(5, array);
            Assert.Equal(result, 0);
        }

        //challange4
        [Fact]

        public void challange4Test1()
        {
            int[] input = { 1, 4, 5, 6, 7, 1 };
            int Output = 1;
            int result = Program.duplicate(input);
            Assert.Equal(result, Output);
        }
        [Fact]
        public void challange4Test2()
        {
            int[] input = { 1, 1, 1, 1, 1, 1 };
            int Output = 1;
            int result = Program.duplicate(input);
            Assert.Equal(result, Output);
        }
        [Fact]
        public void challange4Test3()
        {
            int[] input = { 1, 2, 3, 4, 5, 6 };
            int Output = 1;
            int result = Program.duplicate(input);
            Assert.Equal(result, Output);
        }
        [Fact]
        public void challange4Test4()
        {
            int[] input = { 1, 2, 1, 2, 1, 2 };
            int Output = 1;
            int result = Program.duplicate(input);
            Assert.Equal(result, Output);
        }



        //challange5
        [Fact]
        public void challange5Test1()
        {
            int[] array = { -2, -3, -4, -6, -7, -2 };
            int result = Program.max(array);
            Assert.Equal(result, -2);
        }
        [Fact]
        public void challange5Test2()
        {
            int[] array = { 2, 2, 2, 2, 2, 2 };
            int result = Program.max(array);
            Assert.Equal(result, 2);
        }


        //challange9

        [Fact]
        public void challange9Test1()
        {
            string input = "test sentance";
            string[] Output = { "test : 4 ,", "sentance : 8 " };
            string[] result = Program.numofcar(input);
            Assert.Equal(result, Output);
        }
        [Fact]
        public void challange9Test2()
        {
            string input = "this should return an array of strings";
            string[] Output = { "this : 4 ,", "should : 6 ,", "return : 6 ,", "an : 2 ,", "array : 5 ,", "of : 2 ,", "strings : 7 " };
            string[] result = Program.numofcar(input);
            Assert.Equal(result, Output);
        }
        [Fact]

        public void challange9Test3()
        {
            string input = "? ! ++ = done";
            string[] Output = { "? : 1 ,", "! : 1 ,", "++ : 2 ,", "= : 1 ,", "done : 4 " };
            string[] result = Program.numofcar(input);
            Assert.Equal(result, Output);
        }


    }
}