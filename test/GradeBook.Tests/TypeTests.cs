using System;
using Xunit;

namespace GradeBook.Tests
{
    public class TypeTests
    {

        [Fact]
        public void StringsBehaveLikeValueTypes()
        {
          String name= "Scott";
          var upper= MakeUpperCase(name);
          Assert.Equal("Scott", name);
          Assert.Equal("SCOTT", upper);
        }

        private string MakeUpperCase (String parameter){
            return parameter.ToUpper();
        }

         [Fact]
        public void Test1()
        {
          var x=GetInt();
          SetInt(ref x);
          Assert.Equal(42,x);
        }
         
        private int GetInt(){
            return 3;
        }

        private void SetInt(ref int x){
            x=42;
        }

         [Fact]
        public void CSharpCanPassByRef()
        {
          var book1=GetBook("Book1 ");
          GetBookSetName(ref book1, "New Name");
          Assert.Equal("New Name ", book1.Name);
        }

          private void GetBookSetName(ref Book book, String name)
        {
          book=new Book(name);
          //book.Name=name;
        }

        [Fact]
        public void CSharpIsPassByValue()
        {
          var book1=GetBook("Book1 ");
          GetBookSetName(book1, "New Name");
          Assert.Equal("New Name ", book1.Name);
        }

          private void GetBookSetName(Book book, String name)
        {
          book=new Book(name);
          //book.Name=name;
        }

        [Fact]
        public void CanSetNameFromReference()
        {
          var book1=GetBook("Book1 ");
          SetName(book1, "New Name");
          Assert.Equal("Book1 ", book1.Name);
        }

       
      


        private void SetName(Book b1, String name)
        {
            b1.Name=name;
        }

        [Fact]
        public void GetBookReturnsDifferentObjects()
        {
          var book1=GetBook("Book1 ");
          var book2=GetBook("Book2 ");

          Assert.Equal("", book1.Name);
          Assert.Equal("", book2.Name);
          Assert.NotSame(book1,book2);
        }

         [Fact]
        public void TwoVarsCanReferenceSameObject()
        {
          var book1=GetBook("Book1 ");
          var book2=book1;
          Assert.Same(book1,book2);
          Assert.True(Object.ReferenceEquals(book1,book2));
        }


        Book GetBook(String name){
            return new Book(name);
        }
    }
}
