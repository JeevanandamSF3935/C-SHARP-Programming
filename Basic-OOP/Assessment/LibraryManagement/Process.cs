namespace LibraryManagement;
public class Process
{
    public static List<UserDetails> usersList = new List<UserDetails>();
    public static List<BookDetails> booksList = new List<BookDetails>();
    public static List<BorrowDetails> borrowsList = new List<BorrowDetails>();
    public static void Defaultvalues(){
        //User Default values
        UserDetails user1 = new UserDetails("Ravichandran",Gender.Male,Department.EEE,9938388333,"ravi@gmail.com");
        UserDetails user2 = new UserDetails("Priyadharshini",Gender.Female,Department.CSE,9944444455,"priya@gmail.com");
        usersList.Add(user1);
        usersList.Add(user2);

        //Books Default Values
        BookDetails book1 = new BookDetails("C#","Author1",0);
        BookDetails book2 = new BookDetails("HTML","Author2",5);
        BookDetails book3 = new BookDetails("CSS","Author1",3);
        BookDetails book4 = new BookDetails("JS","Author1",3);
        BookDetails book5 = new BookDetails("TS","Author2",2);
        booksList.Add(book1);
        booksList.Add(book2);
        booksList.Add(book3);
        booksList.Add(book4);
        booksList.Add(book5);

        //Borrow Books Default Values
        BorrowDetails borrow1 = new BorrowDetails("BID101","SF3001",new DateTime(2022,04,10),new DateTime(2022,04,10).AddDays(15),BookStatus.Issued);
        BorrowDetails borrow2 = new BorrowDetails("BID103","SF3001",new DateTime(2022,04,12),new DateTime(2022,04,12).AddDays(15),BookStatus.Returned);
        BorrowDetails borrow3 = new BorrowDetails("BID104","SF3001",new DateTime(2022,04,15),new DateTime(2022,04,15).AddDays(15),BookStatus.Issued);
        BorrowDetails borrow4 = new BorrowDetails("BID101","SF3002",new DateTime(2022,04,11),new DateTime(2022,04,11).AddDays(15),BookStatus.Returned);
        BorrowDetails borrow5 = new BorrowDetails("BID105","SF3002",new DateTime(2022,04,15),new DateTime(2022,04,15).AddDays(15),BookStatus.Issued);
        borrowsList.Add(borrow1);
        borrowsList.Add(borrow4);
        borrowsList.Add(borrow2);
        borrowsList.Add(borrow3);
        borrowsList.Add(borrow5);
    }

    public static void UserRegister(){
        Gender gender;
        Department department;
        System.Console.Write("Enter your name : ");
        string userName = Console.ReadLine();
        System.Console.Write("Enter your Gender (Male or Female or Transgender) : ");
        bool genderTemp = Gender.TryParse(Console.ReadLine(),true,out gender);
        if(!genderTemp){
            System.Console.WriteLine("Invalid Input\nEnter again!!!");
            genderTemp = Gender.TryParse(Console.ReadLine(),true,out gender);
        }
        System.Console.Write("Enter your department (EEE or CSE or ECE) : ");
        bool departmentTemp = Gender.TryParse(Console.ReadLine(),true,out department);
        if(!departmentTemp){
            System.Console.WriteLine("Invalid Input\nEnter again!!!");
            departmentTemp = Gender.TryParse(Console.ReadLine(),true,out department);
        }
        System.Console.Write("Enter your mobile number : ");
        long phoneNumber = long.Parse(Console.ReadLine());
        System.Console.Write("Enter your MailID : ");
        string mailID = Console.ReadLine();
        UserDetails user = new UserDetails(userName,gender,department,phoneNumber,mailID);
        usersList.Add(user);
        System.Console.WriteLine($"Registered Successfully!\nYour registerID is : {user.RegisterID}");
    }

    public static void UserLogin(){
        bool userCheck = true;
        System.Console.Write("Enter the register ID : ");
        string registerID = Console.ReadLine().ToUpper();
        foreach(UserDetails users in usersList){
            if(users.RegisterID == registerID){
                System.Console.WriteLine("Login Successfull");
                MenuClass.SubMenu(users);
                break;
            }
            else{
                userCheck = false;
            }
        }
        if(!userCheck){
            System.Console.WriteLine("Login Unsuccessfull\nTry agian with valid RegisterID");
        }
    }
    
    public static void BorrowBook(UserDetails user){
        bool availableCheck = true;
        DateTime availableDate = new DateTime();
        int borrowCount = 0;
        BookDetails.ShowBooks();
        System.Console.Write("Enter the book id that you want to borrow : ");
        string bookID = Console.ReadLine().ToUpper();
        foreach(BookDetails book in booksList){
            if(book.BookID == bookID){
                if(book.BookCount > 0){
                    foreach(BorrowDetails borrow in borrowsList){
                        if(borrow.RegisterID == user.RegisterID && borrow.Status == BookStatus.Issued){
                            borrowCount++;
                        }
                    }
                    if(borrowCount >= 3){
                        System.Console.WriteLine("You cannot borrow book!\nYou crossed your borrow limit!\nReturn borrowed book to borrow a new book");
                    }
                    else{
                        BorrowDetails borrow = new BorrowDetails(bookID,user.RegisterID,DateTime.Now,DateTime.Now.AddDays(15),BookStatus.Issued);
                        borrowsList.Add(borrow);
                        System.Console.WriteLine($"Borrowed Successfully\nYour BorrowID is {borrow.BorrowID}");
                        book.BookCount--;
                    }
                }
                else{
                    System.Console.WriteLine("Book are not available the selected count");
                    foreach(BorrowDetails borrow in borrowsList){
                        if(book.BookID == borrow.BookID){
                            availableDate = borrow.DueDate;
                            break;
                        }
                    }
                    System.Console.WriteLine($"The book will be available after {availableDate.ToString("dd/MM/yyyy")}");
                }
                availableCheck = true;
                break;
            }
            else{
                availableCheck = false;
            }
        }
        if(!availableCheck){
            System.Console.WriteLine("BookID is not valid");
        }
    }

    public static void ReturnBook(UserDetails user){
        bool returnCheck = true;
        BorrowedHistory(user);
        System.Console.Write("Enter the bookID want to return : ");
        string bookId = Console.ReadLine().ToUpper();
        foreach(BorrowDetails borrow in borrowsList){
            if(borrow.BookID == bookId){
                TimeSpan bookTaken = DateTime.Now - borrow.DueDate;
                double timeTaken = Math.Round(bookTaken.TotalDays);
                if(borrow.Status == BookStatus.Issued){
                    if(timeTaken > 15){
                        int fineAmount = (int)timeTaken - 15;
                        System.Console.WriteLine($"Your due time elapsed {timeTaken-15} days\nYou should pay fine Rs.{fineAmount}");
                        if(user.WalletBalance < fineAmount){
                            RechargeWallet(user);
                            user.WalletBalance -= fineAmount;
                            borrow.Status = BookStatus.Returned;
                            System.Console.WriteLine("Book returned successfully");
                            foreach(BookDetails book in booksList){
                                if(book.BookID == bookId){
                                    book.BookCount++;
                                }
                            }
                            returnCheck = true;
                        }
                        else{
                            user.WalletBalance -= fineAmount;
                            borrow.Status = BookStatus.Returned;
                            System.Console.WriteLine("Book returned successfully");
                            foreach(BookDetails book in booksList){
                                if(book.BookID == bookId){
                                    book.BookCount++;
                                }
                            }
                            returnCheck = true;
                        }
                    }
                    else{
                        borrow.Status = BookStatus.Returned;
                        System.Console.WriteLine("Book returned successfully");
                        foreach(BookDetails book in booksList){
                            if(book.BookID == bookId){
                                book.BookCount++;
                            }
                        }
                        returnCheck = true;
                    }
                }
                else{
                    System.Console.WriteLine("Book is already returned");
                    returnCheck = false;
                }
                break;
            }
            else{
                returnCheck = false;
            }
        }
        if(!returnCheck){
            System.Console.WriteLine("BookId not in your borrowed history");
        }
    }

    public static void BorrowedHistory(UserDetails user){
        System.Console.WriteLine("BorrowID\tBookID\tRegistrationID\tBorrowed Date\tDue Date\tBorrow status");
        foreach(BorrowDetails borrow in borrowsList){
            if(borrow.RegisterID == user.RegisterID){
                System.Console.WriteLine($"{borrow.BorrowID}\t\t{borrow.BookID}\t{borrow.RegisterID}\t\t{borrow.BorrowedDate.ToString("dd/MM/yyyy")}\t{borrow.DueDate.ToString("dd/MM/yyyy")}\t{borrow.Status}");
            }
        }
    }

    public static void RechargeWallet(UserDetails user){
        System.Console.Write("Enter the amount to be recharged in your wallet : ");
        int rechargeAmount = int.Parse(Console.ReadLine());
        user.WalletBalance += rechargeAmount;
        System.Console.WriteLine($"Rs.{rechargeAmount} has been recharged to your wallet");
    }

}