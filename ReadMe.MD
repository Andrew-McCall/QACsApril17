https://pastebin.com/XPG8iwfR

       [Fact]
        public void Create()
        {
            Library library = new Library();
            Member greta = library.Add(name: "Greta Thunberg", age: 15);
            Member donald = donald = library.Add(name: "Donald Trump", age: 73);
 
            Assert.Equal(2, library.NumberOfMembers);
            Assert.Equal(1, greta.MembershipNumber);
            Assert.Equal(2, donald.MembershipNumber);
        }
 
#######################################################################################
 
Library
-------
    public class Library
    {
        Dictionary<int, Member> members = new Dictionary<int, Member>();
 
        public int NumberOfMembers => members.Keys.Count;
 
        int GetNextFreeMembershipNumber()
        {
            return (members.Keys.Count == 0) ? 1 : members.Keys.Max() + 1;
        }
 
        public Member Add(string name, int age)
        {
            Member member = new Member(name, age, GetNextFreeMembershipNumber());
            members.Add(member.MembershipNumber, member);
            return member;
        }
    }
 
#######################################################################################
 
Member
------
    public class Member
    {
        public string Name { get; }
        public int MembershipNumber { get; }
        public int Age { get; }
 
        public Member(string name, int age, int membershipNumber)
        {
            this.Name = name;
            this.Age = age;
            this.MembershipNumber = membershipNumber;
        }
    }
 
 
###################### FILE 2
    public class UnitTest1
    {
        Library library;
        Member greta;
        Member donald;
 
        public UnitTest1()
        {
            library = new Library();
            greta = library.Add(name: "Greta Thunberg", age: 15);
            donald = donald = library.Add(name: "Donald Trump", age: 73);
        }
 
        [Fact]
        public void Create()
        {
            Assert.Equal(2, library.NumberOfMembers);
            Assert.Equal(1, greta.MembershipNumber);
            Assert.Equal(2, donald.MembershipNumber);
        }
    }
################ File 3
[Fact]
public void Child_Borrows_Child_Book_OK()
{
    // a junior member (under 16) can borrow only child category books
    Book childBook = library.GetBook(101);
    Assert.True(greta.Borrow(childBook));
}
############## file 4
        [Fact]
        public void Child_Borrows_Adult_Book_Fails()
        {
            // a junior member (under 16) can borrow only child category books
            Book adultBook = library.GetBook(100);
            Assert.False(greta.Borrow(adultBook));
        }
############## file 5
        [Fact]
        public void Adult_Can_Borrow_Any_Book()
        {
            // a junior member (under 16) can borrow only child category books
            Book adultBook = library.GetBook(100);
            Book childBook = library.GetBook(101);
            Assert.True(donald.Borrow(adultBook));
            Assert.True(donald.Borrow(childBook));
        }
############## file 6
        [Fact]
        public void Child_Pays_Fine_From_Cash_Fund()
        {
            greta.CashFund = 20M;
            greta.PayFine(7M);
            Assert.Equal(13M,greta.CashFund);
        }
 
        [Fact]
        public void Adult_Pays_Fine_By_Bank_Transfer()
        {
            donald.SetUpBankTransferLimit(20M);
            donald.PayFine(7M);
            Assert.Equal(13M, donald.BankTransferAvailable);
        }