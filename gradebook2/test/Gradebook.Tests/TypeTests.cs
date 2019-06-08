using System;
using Xunit;

namespace Gradebook.Tests
{

    public delegate string WriteLogDelegate(string logMessage);
    public class TypeTests
    {

        int count = 0;
        [Fact]
        public void WriteLogDelegateTest(){
            WriteLogDelegate log;
            //long hand form
            //log = new WriteLogDelegate(ReturnMessage);
            log =ReturnMessage;
            var result = log("Hello");
            Assert.Equal("Hello", result);

        }

        [Fact]
        public void WriteLogMulticastDelegateTest(){
            WriteLogDelegate log =ReturnMessage;
            log +=ReturnMessage;
            log +=IncrementMessage;
            var result = log("Hello");
            Assert.Equal("hello", result);
            Assert.Equal(3,count);

        }

        string IncrementMessage(string message){
            count++;
            return message.ToLower();
        }
        string ReturnMessage(string message){
            count++;
            return message;
        }
        //fact is equivalent to @Test
        [Fact]
        public void Test1()
        {
             var book1 = GetBook("Book 1");
             var book2 = GetBook("Book 2");
            
            Assert.Equal("Book 1", book1.Name);
            Assert.Equal("Book 2", book2.Name);
        }

        //Assert two objects reference same instance
        [Fact]
        public void TwoVarCanReferenceSameBook()
        {
             var book1 = GetBook("Book 1");
             var book2 = book1;
            
            Assert.Same(book1,book2);
            Assert.True(object.ReferenceEquals(book1,book2)); //equivalent to Same
        }

        [Fact]
        public void PassByValueTest()
        {
             var book1 = GetBook("Book 1");
             SetName(book1, "New Name");
            
            Assert.Equal("New Name", book1.Name);
        }

        private void SetName(InMemoryBook book, string name)
        {
            book.Name = name;
        }

        [Fact]
        public void PassByValueTestNewObj()
        {
             var book1 = GetBook("Book 1");
             CreateBookAndSetName(book1, "New Name");
            // because we always pass by value in c#
            Assert.Equal("Book 1", book1.Name);
        }

        private void CreateBookAndSetName(InMemoryBook book, string name)
        {
            book = new InMemoryBook(name);
        }

        [Fact]
        public void ValueTypeTest()
        {
             var x = GetInt();
             SetInt(ref x);
             

             Assert.Equal(42,x);
        }

        private void SetInt(ref int z)
        {
            z=42;
        }

        private int GetInt()
        {
            return 3;
        }

        [Fact]
        public void PassByReferenceTest()
        {
             var book1 = GetBook("Book 1");
             CreateBookAndSetNameByRef(ref book1, "New Name");
            // because we always pass by value in c#
            Assert.Equal("New Name", book1.Name);
        }

        private void CreateBookAndSetNameByRef(ref InMemoryBook book, string name)
        {
            book = new InMemoryBook(name);
        }

        InMemoryBook GetBook(string name)
        {
            return new InMemoryBook(name);
        }

        [Fact]
        public void StringsBehaveLikeValueTypes(){
            string name = "Scott";
            var upper = MakeUppercase(name);

            Assert.Equal("SCOTT", upper);
            
        }

        private string MakeUppercase(string name)
        {
            return name.ToUpper();
        }
    }
}
