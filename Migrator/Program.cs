using System;
using System.IO;
using System.Linq;
using System.Text;
using DAL;

namespace Migrator
{
    class Program
    {
        private static readonly IUnitOfWork UnitOfWork = new UnitOfWork();
        static void Main(string[] args)
        {
            Program program = new Program();
            program.UpdateUsers();
         //   program.UpdateBlogItems();

        }

        private void Example()
        {
            using (FileStream fs = new FileStream(@"C:\\.txt", FileMode.Open))
            {
                byte[] data = new byte[fs.Length];
                fs.Read(data, 0, Convert.ToInt32(fs.Length));

                char[] chars = Encoding.UTF8.GetString(data).ToCharArray();
                for (int i = 0; i < chars.Length; i++)
                {
                    User user = new User();
                    // login
                    while (chars[i] != '|')
                    {
                        user.Login += chars[i];
                        i++;
                    }
                    // last modified
                    string lastDate = null;
                    while (chars[i] != '|')
                    {
                        lastDate += chars[i];
                        i++;
                    }
                    user.LastModifiedUTC = long.Parse(lastDate);
                    UnitOfWork.UserRepository.Add(user);
                    while (chars[i] != 10)
                    {
                        i++;
                    }
                }
                UnitOfWork.Save();
            }

        }

        private void UpdateUsers()
        {
            using (FileStream fs = new FileStream(@"C:\\users.txt", FileMode.Open))
            {
                byte[] data = new byte[fs.Length];
                fs.Read(data, 0, Convert.ToInt32(fs.Length));

                char[] chars = Encoding.UTF8.GetString(data).ToCharArray();
                for (int i = 0; i < chars.Length; i++)
                {
                    User user = new User();
                    // login
                    while (chars[i] != '|')
                    {
                        user.Login += chars[i];
                        i++;
                    }
                    i++;
                    // uid 
                    while (chars[i] != '|')
                    {
                        i++;
                    }
                    i++;
                    // pass
                    while (chars[i] != '|')
                    {
                        i++;
                    }
                    i++;
                    // photopath
                    while (chars[i] != '|')
                    {
                        i++;
                    }
                    i++;
                    // flags ???
                    string flags = null;
                    while (chars[i] != '|')
                    {
                        flags += chars[i];
                        i++;
                    }
                    i++;
                    // fullname
                    while (chars[i] != '|')
                    {
                        user.FullName += chars[i];
                        i++;
                    }
                    i++;
                    // gender
                    while (chars[i] != '|')
                    {
                        if (chars[i] == 1)
                            user.Gender = true;
                        i++;
                    }
                    i++;
                    // email
                    while (chars[i] != '|')
                    {
                        user.Email += chars[i];
                        i++;
                    }
                    i++;
                    // homepage
                    while (chars[i] != '|')
                    {
                        user.Homepage += chars[i];
                        i++;
                    }
                    i++;
                    // icq
                    while (chars[i] != '|')
                    {
                        i++;
                    }
                    i++;
                    // counry
                    while (chars[i] != '|')
                    {
                        user.Country += chars[i];
                        i++;
                    }
                    i++;
                    // state
                    while (chars[i] != '|')
                    {
                        i++;
                    }
                    i++;
                    // city
                    while (chars[i] != '|')
                    {
                        user.City += chars[i];
                        i++;
                    }
                    i++;
                    // signature
                    while (chars[i] != '|')
                    {
                        i++;
                    }
                    i++;
                    // title
                    while (chars[i] != '|')
                    {
                        user.Title += chars[i];
                        i++;
                    }
                    i++;
                    // regdate
                    string regdate = null;
                    while (chars[i] != '|')
                    {
                        regdate += chars[i];
                        i++;
                    }
                    user.RegistrationDateUTC = long.Parse(regdate);
                    i++;
                    // ip
                    while (chars[i] != '|')
                    {
                        user.Ip += chars[i];
                        i++;
                    }
                    i++;
                    // o ld-field
                    string hz = null;
                    while (chars[i] != '|')
                    {
                        hz += chars[i];
                        i++;
                    }
                    i++;
                    // aol
                    while (chars[i] != '|')
                    {
                        i++;
                    }
                    i++;
                    // msn
                    while (chars[i] != '|')
                    {
                        i++;
                    }
                    i++;
                    // yahoo
                    while (chars[i] != '|')
                    {
                        i++;
                    }
                    i++;
                    // ispm
                    string ispm = null;
                    while (chars[i] != '|')
                    {
                        ispm += chars[i];
                        i++;
                    }
                    i++;
                    // birthday
                    string birthday = null;
                    while (chars[i] != '|')
                    {
                        birthday += chars[i];
                        i++;
                    }
                    if (birthday != null)
                    {
                        user.Birthday = DateTime.Parse(birthday);
                    }
                    i++;
                    // verify
                    string fv = null;
                    while (chars[i] != '|')
                    {

                        fv += chars[i];
                        if (chars[i] == '0')
                        {
                            user.Verify = true;
                        }
                        i++;
                    }
                    i++;
                    // options
                    string fe = null;
                    while (chars[i] != '|')
                    {
                        fe += chars[i];
                        i++;
                    }
                    i++;
                    // last modified
                    string lastDate = null;
                    
                    while (chars[i] != '|')
                    {
                        if (char.IsDigit(chars[i]) && chars[i + 1] == '\\')
                        {
                            i+=3;
                        }
                        
                        lastDate += chars[i];
                        i++;
                    }
                    user.LastModifiedUTC = long.Parse(lastDate);
                    UnitOfWork.UserRepository.Add(user);
                    while (chars[i] != 10)
                    {
                        i++;
                    }
                }
                UnitOfWork.Save();
            }
        }

        private void UpdateBlogItems()
        {
            using (FileStream fs = new FileStream(@"C:\\blog.txt", FileMode.Open))
            {
                byte[] data = new byte[fs.Length];
                fs.Read(data, 0, Convert.ToInt32(fs.Length));

                char[] chars = Encoding.UTF8.GetString(data).ToCharArray();
                for (int i = 0; i < chars.Length; i++)
                {
                    BlogItem blogItem = new BlogItem();
                    // id
                    string id = null;
                    while (chars[i] != '|')
                    {
                        id += chars[i];
                        i++;
                    }
                    blogItem.Id = int.Parse(id);
                    // Category id
                    string categoryId = null;
                    while (chars[i] != '|')
                    {
                        categoryId += chars[i];
                        i++;
                    }
                    blogItem.CategoryId = int.Parse(categoryId);
                    // year
                    string year = null;
                    while (chars[i] != '|')
                    {
                        year += chars[i];
                        i++;
                    }
                    blogItem.Year = int.Parse(year);
                    // month
                    string month = null;
                    while (chars[i] != '|')
                    {
                        month += chars[i];
                        i++;
                    }
                    blogItem.Month = int.Parse(month);
                    // day
                    string day = null;
                    while (chars[i] != '|')
                    {
                        day += chars[i];
                        i++;
                    }
                    blogItem.Day = int.Parse(day);
                    // pending
                    while (chars[i] != '|')
                    {
                        if (chars[i] == '1')
                        blogItem.Pending = true;
                        i++;
                    }
                    // onTop
                    while (chars[i] != '|')
                    {
                        if (chars[i] == '1')
                            blogItem.OnTop = true;
                        i++;
                    }
                    //commentary_may
                    while (chars[i] != '|')
                    {
                        if (chars[i] == '1')
                            blogItem.CanCommentary = true;
                        i++;
                    }
                    //add time
                    string addTime = null;
                    while (chars[i] != '|')
                    {
                        addTime += chars[i];
                        i++;
                    }
                    blogItem.AdditionTime = long.Parse(addTime);
                    // commentary Number
                    string numberCommentary = null;
                    while (chars[i] != '|')
                    {
                        numberCommentary += chars[i];
                        i++;
                    }
                    blogItem.NumberCommentaries = int.Parse(numberCommentary);
                    //author
                    string userName = null;
                    while (chars[i] != '|')
                    {
                        userName += chars[i];
                        i++;
                    }
                    blogItem.User = UnitOfWork.UserRepository.Get(u => u.Login == userName).FirstOrDefault();
                    //title
                    string title = null;
                    while (chars[i] != '|')
                    {
                        title += chars[i];
                        i++;
                    }
                    blogItem.Title = title;
                    //brief
                    string brief = null;
                    while (chars[i] != '|')
                    {
                        brief += chars[i];
                        i++;
                    }
                    blogItem.Brief = brief;
                    // message
                    string message = null;
                    while (chars[i] != '|')
                    {
                        message += chars[i];
                        i++;
                    }
                    blogItem.Message = message;
                    // attach
                    while (chars[i] != '|')
                    {
                        id += chars[i];
                        i++;
                    }
                    // files
                    while (chars[i] != '|')
                    {
                        id += chars[i];
                        i++;
                    }
                    // reads
                    string reads = null;
                    while (chars[i] != '|')
                    {
                        reads += chars[i];
                        i++;
                    }
                    blogItem.Reads = int.Parse(reads);
                    // rating
                    string rating = null;
                    while (chars[i] != '|')
                    {
                        rating += chars[i];
                        i++;
                    }
                    blogItem.Rating = byte.Parse(rating);
                    // rate_num
                    string ratingNumbers = null;
                    while (chars[i] != '|')
                    {
                        ratingNumbers += chars[i];
                        i++;
                    }
                    blogItem.RatingNumbers = int.Parse(ratingNumbers);
                    // rate sum
                    string ratingSumm = null;
                    while (chars[i] != '|')
                    {
                        ratingSumm += chars[i];
                        i++;
                    }
                    blogItem.RatingSumm = int.Parse(ratingSumm);
                    //rate ip
                    while (chars[i] != '|')
                    {
                        reads += chars[i];
                        i++;
                    }
                    // other 1
                    while (chars[i] != '|')
                    {
                        reads += chars[i];
                        i++;
                    }
                    // other 2
                    while (chars[i] != '|')
                    {
                        reads += chars[i];
                        i++;
                    }
                    // other 3
                    while (chars[i] != '|')
                    {
                        reads += chars[i];
                        i++;
                    }
                    // other 4
                    while (chars[i] != '|')
                    {
                        reads += chars[i];
                        i++;
                    }
                    // other 5
                    while (chars[i] != '|')
                    {
                        reads += chars[i];
                        i++;
                    }
                    // last modified
                    string lastDate = null;
                    while (chars[i] != '|')
                    {
                        lastDate += chars[i];
                        i++;
                    }
                    // uid
                    while (chars[i] != '|')
                    {
                        reads += chars[i];
                        i++;
                    }
                    // subscr
                    while (chars[i] != '|')
                    {
                        reads += chars[i];
                        i++;
                    }
                 //   blogItem.LastModifiedUTC = long.Parse(lastDate);
                  //  UnitOfWork.BlogItemRepository.Add(blogItem);
                    while (chars[i] != 10)
                    {
                        i++;
                    }
                }
                //UnitOfWork.Save();
            }
        }

        private void UpdateNewsItems()
        {
            using (FileStream fs = new FileStream(@"C:\\news.txt", FileMode.Open))
            {
                byte[] data = new byte[fs.Length];
                fs.Read(data, 0, Convert.ToInt32(fs.Length));

                char[] chars = Encoding.UTF8.GetString(data).ToCharArray();
                for (int i = 0; i < chars.Length; i++)
                {
                    BlogItem blogItem = new BlogItem();
                    // id
                    string id = null;
                    while (chars[i] != '|')
                    {
                        id += chars[i];
                        i++;
                    }
                    blogItem.Id = int.Parse(id);
                    // Category id
                    string categoryId = null;
                    while (chars[i] != '|')
                    {
                        categoryId += chars[i];
                        i++;
                    }
                    blogItem.CategoryId = int.Parse(categoryId);
                    // year
                    string year = null;
                    while (chars[i] != '|')
                    {
                        year += chars[i];
                        i++;
                    }
                    blogItem.Year = int.Parse(year);
                    // month
                    string month = null;
                    while (chars[i] != '|')
                    {
                        month += chars[i];
                        i++;
                    }
                    blogItem.Month = int.Parse(month);
                    // day
                    string day = null;
                    while (chars[i] != '|')
                    {
                        day += chars[i];
                        i++;
                    }
                    blogItem.Day = int.Parse(day);
                    // pending
                    while (chars[i] != '|')
                    {
                        if (chars[i] == '1')
                            blogItem.Pending = true;
                        i++;
                    }
                    // onTop
                    while (chars[i] != '|')
                    {
                        if (chars[i] == '1')
                            blogItem.OnTop = true;
                        i++;
                    }
                    //commentary_may
                    while (chars[i] != '|')
                    {
                        if (chars[i] == '1')
                            blogItem.CanCommentary = true;
                        i++;
                    }
                    //add time
                    string addTime = null;
                    while (chars[i] != '|')
                    {
                        addTime += chars[i];
                        i++;
                    }
                    blogItem.AdditionTime = long.Parse(addTime);
                    // commentary Number
                    string numberCommentary = null;
                    while (chars[i] != '|')
                    {
                        numberCommentary += chars[i];
                        i++;
                    }
                    blogItem.NumberCommentaries = int.Parse(numberCommentary);
                    //author
                    string userName = null;
                    while (chars[i] != '|')
                    {
                        userName += chars[i];
                        i++;
                    }
                    blogItem.User = UnitOfWork.UserRepository.Get(u => u.Login == userName).FirstOrDefault();
                    //title
                    string title = null;
                    while (chars[i] != '|')
                    {
                        title += chars[i];
                        i++;
                    }
                    blogItem.Title = title;
                    //brief
                    string brief = null;
                    while (chars[i] != '|')
                    {
                        brief += chars[i];
                        i++;
                    }
                    blogItem.Brief = brief;
                    // message
                    string message = null;
                    while (chars[i] != '|')
                    {
                        message += chars[i];
                        i++;
                    }
                    blogItem.Message = message;
                    // attach
                    while (chars[i] != '|')
                    {
                        id += chars[i];
                        i++;
                    }
                    // files
                    while (chars[i] != '|')
                    {
                        id += chars[i];
                        i++;
                    }
                    // reads
                    string reads = null;
                    while (chars[i] != '|')
                    {
                        reads += chars[i];
                        i++;
                    }
                    blogItem.Reads = int.Parse(reads);
                    // rating
                    string rating = null;
                    while (chars[i] != '|')
                    {
                        rating += chars[i];
                        i++;
                    }
                    blogItem.Rating = byte.Parse(rating);
                    // rate_num
                    string ratingNumbers = null;
                    while (chars[i] != '|')
                    {
                        ratingNumbers += chars[i];
                        i++;
                    }
                    blogItem.RatingNumbers = int.Parse(ratingNumbers);
                    // rate sum
                    string ratingSumm = null;
                    while (chars[i] != '|')
                    {
                        ratingSumm += chars[i];
                        i++;
                    }
                    blogItem.RatingSumm = int.Parse(ratingSumm);
                    //rate ip
                    while (chars[i] != '|')
                    {
                        reads += chars[i];
                        i++;
                    }
                    // other 1
                    while (chars[i] != '|')
                    {
                        reads += chars[i];
                        i++;
                    }
                    // other 2
                    while (chars[i] != '|')
                    {
                        reads += chars[i];
                        i++;
                    }
                    // other 3
                    while (chars[i] != '|')
                    {
                        reads += chars[i];
                        i++;
                    }
                    // other 4
                    while (chars[i] != '|')
                    {
                        reads += chars[i];
                        i++;
                    }
                    // other 5
                    while (chars[i] != '|')
                    {
                        reads += chars[i];
                        i++;
                    }
                    // last modified
                    string lastDate = null;
                    while (chars[i] != '|')
                    {
                        lastDate += chars[i];
                        i++;
                    }
                    // uid
                    while (chars[i] != '|')
                    {
                        reads += chars[i];
                        i++;
                    }
                    // subscr
                    while (chars[i] != '|')
                    {
                        reads += chars[i];
                        i++;
                    }
                    //   blogItem.LastModifiedUTC = long.Parse(lastDate);
                    //  UnitOfWork.BlogItemRepository.Add(blogItem);
                    while (chars[i] != 10)
                    {
                        i++;
                    }
                }
                //UnitOfWork.Save();
            }
        }
    }
}
