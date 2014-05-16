using System;
using System.IO;
using System.Linq;
using System.Text;
using Common.Entities;
using DAL;
using DAL.models;

namespace Migrator
{
    class Program
    {
        private static readonly IUnitOfWork UnitOfWork = new UnitOfWork();
        static void Main(string[] args)
        {
         //  UpdateUsers();
        //   UpdateBlogItems();
         //  UpdateNewsItems();
         //   UpdateBlogCategory();
            UpdateNewsCategory();



        }

        private static void Example()
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

        private static void UpdateUsers()
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

        private static void UpdateBlogItems()
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
                    i++;
                    // Category id
                    string categoryId = null;
                    while (chars[i] != '|')
                    {
                        categoryId += chars[i];
                        i++;
                    }
                    blogItem.CategoryId = int.Parse(categoryId);
                    i++;
                    // year
                    string year = null;
                    while (chars[i] != '|')
                    {
                        year += chars[i];
                        i++;
                    }
                    blogItem.Year = int.Parse(year);
                    i++;
                    // month
                    string month = null;
                    while (chars[i] != '|')
                    {
                        month += chars[i];
                        i++;
                    }
                    blogItem.Month = int.Parse(month);
                    i++;
                    // day
                    string day = null;
                    while (chars[i] != '|')
                    {
                        day += chars[i];
                        i++;
                    }
                    blogItem.Day = int.Parse(day);
                    i++;
                    // pending
                    while (chars[i] != '|')
                    {
                        if (chars[i] == '1')
                        blogItem.Pending = true;
                        i++;
                    }
                    i++;
                    // onTop
                    while (chars[i] != '|')
                    {
                        if (chars[i] == '1')
                            blogItem.OnTop = true;
                        i++;
                    }
                    i++;
                    //commentary_may
                    while (chars[i] != '|')
                    {
                        if (chars[i] == '1')
                            blogItem.CanCommentary = true;
                        i++;
                    }
                    i++;
                    //add time
                    string addTime = null;
                    while (chars[i] != '|')
                    {
                        addTime += chars[i];
                        i++;
                    }
                    i++;
                    blogItem.AdditionTime = long.Parse(addTime);
                    // commentary Number
                    string numberCommentary = null;
                    while (chars[i] != '|')
                    {
                        numberCommentary += chars[i];
                        i++;
                    }
                    i++;
                    blogItem.NumberCommentaries = int.Parse(numberCommentary);
                    //author
                    string userName = null;
                    while (chars[i] != '|')
                    {
                        userName += chars[i];
                        i++;
                    }
                    i++;
                    
                    blogItem.User = UnitOfWork.UserRepository.Get(u => u.Login == userName).FirstOrDefault();
                    //title
                    string title = null;
                    while (chars[i] != '|')
                    {
                        title += chars[i];
                        i++;
                    }
                    i++;
                    
                    blogItem.Title = title;
                    //brief
                    string brief = null;
                    while (chars[i] != '|')
                    {
                        brief += chars[i];
                        i++;
                    }
                    i++;
                    
                    blogItem.Brief = brief;
                    // message
                    string message = null;
                    while (chars[i] != '|')
                    {
                        message += chars[i];
                        i++;
                    }
                    i++;
                    
                    blogItem.Message = message;
                    // attach
                    while (chars[i] != '|')
                    {
                        id += chars[i];
                        i++;
                    }
                    i++;
                    
                    // files
                    while (true)
                    {
                        if (chars[i] == '\\' && chars[i + 1] == '|' && chars[i + 2] == '|')
                        {
                            break;
                        }
                        i++;
                    }
                    i+=3;
                    //i++;
                    
                    // reads
                    string reads = null;
                    
                    
                    while (chars[i] != '|')
                    {
                        reads += chars[i];
                        i++;
                    }
                    i++;
                    
                    blogItem.Reads = int.Parse(reads);
                    // rating
                    string rating = null;
                    while (chars[i] != '|')
                    {
                        rating += chars[i];
                        i++;
                    }
                    i++;
                    
                    blogItem.Rating = float.Parse(rating);
                    // rate_num
                    string ratingNumbers = null;
                    while (chars[i] != '|')
                    {
                        ratingNumbers += chars[i];
                        i++;
                    }
                    i++;
                    
                    blogItem.RatingNumbers = int.Parse(ratingNumbers);
                    // rate sum
                    string ratingSumm = null;
                    while (chars[i] != '|')
                    {
                        ratingSumm += chars[i];
                        i++;
                    }
                    i++;
                    
                    blogItem.RatingSumm = int.Parse(ratingSumm);
                    //rate ip
                    while (chars[i] != '|')
                    {
                        reads += chars[i];
                        i++;
                    }
                    i++;
                    
                    // other 1
                    while (chars[i] != '|')
                    {
                        reads += chars[i];
                        i++;
                    }
                    i++;

                    // other 2 SOURCE
                    string source = null;
                    while (chars[i] != '|')
                    {
                        source += chars[i];
                        i++;
                    }
                    blogItem.Source = source;
                    i++;
                    
                    // other 3
                    while (chars[i] != '|')
                    {
                        reads += chars[i];
                        i++;
                    }
                    i++;
                    
                    // other 4
                    while (chars[i] != '|')
                    {
                        reads += chars[i];
                        i++;
                    }
                    i++;
                    
                    // other 5
                    while (chars[i] != '|')
                    {
                        reads += chars[i];
                        i++;
                    }
                    i++;
                    // other6
                    while (chars[i] != '|')
                    {
                        // reads += chars[i];
                        i++;
                    }
                    i++;

                    // uid
                    while (chars[i] != '|')
                    {
                       // reads += chars[i];
                        i++;
                    }
                    i++;
                    
                    // subscr
                    while (chars[i] != '|')
                    {
                       // reads += chars[i];
                        i++;
                    }
                    i++;

                    // last modified
                    string lastDate = null;
                    while (char.IsDigit(chars[i]))// != '|' || chars[i] != '\\'))
                    {
                        lastDate += chars[i];
                        i++;
                    }
                    //i++;

                    blogItem.LastModifiedUTC = long.Parse(lastDate);
                    UnitOfWork.BlogItemRepository.Add(blogItem);
                   // while (chars[i] != 10)
                  //  {
                 //       i++;
                  //  }
                }
                UnitOfWork.Save();
            }
        }

        private static void UpdateNewsItems()
        {
            using (FileStream fs = new FileStream(@"C:\news.txt", FileMode.Open))
            {
                byte[] data = new byte[fs.Length];
                fs.Read(data, 0, Convert.ToInt32(fs.Length));

                char[] chars = Encoding.UTF8.GetString(data).ToCharArray();
                for (int i = 0; i < chars.Length; i++)
                {
                    NewsItem newsItem = new NewsItem();
                    // id
                    string id = null;
                    while (chars[i] != '|')
                    {
                        id += chars[i];
                        i++;
                    }
                    newsItem.Id = int.Parse(id);
                    i++;
                    // Category id
                    string categoryId = null;
                    while (chars[i] != '|')
                    {
                        categoryId += chars[i];
                        i++;
                    }
                    newsItem.CategoryId = int.Parse(categoryId);
                    i++;
                    // year
                    string year = null;
                    while (chars[i] != '|')
                    {
                        year += chars[i];
                        i++;
                    }
                    newsItem.Year = int.Parse(year);
                    i++;
                    // month
                    string month = null;
                    while (chars[i] != '|')
                    {
                        month += chars[i];
                        i++;
                    }
                    newsItem.Month = int.Parse(month);
                    i++;
                    // day
                    string day = null;
                    while (chars[i] != '|')
                    {
                        day += chars[i];
                        i++;
                    }
                    newsItem.Day = int.Parse(day);
                    i++;
                    // pending
                    while (chars[i] != '|')
                    {
                        if (chars[i] == '1')
                            newsItem.Pending = true;
                        i++;
                    }
                    i++;
                    // onTop
                    while (chars[i] != '|')
                    {
                        if (chars[i] == '1')
                            newsItem.OnTop = true;
                        i++;
                    }
                    i++;
                    //commentary_may
                    while (chars[i] != '|')
                    {
                        if (chars[i] == '1')
                            newsItem.CanCommentary = true;
                        i++;
                    }
                    i++;
                    //add time
                    string addTime = null;
                    while (chars[i] != '|')
                    {
                        addTime += chars[i];
                        i++;
                    }
                    i++;
                    newsItem.AdditionTime = long.Parse(addTime);
                    // commentary Number
                    string numberCommentary = null;
                    while (chars[i] != '|')
                    {
                        numberCommentary += chars[i];
                        i++;
                    }
                    i++;
                    newsItem.NumberCommentaries = int.Parse(numberCommentary);
                    //author
                    string userName = null;
                    while (chars[i] != '|')
                    {
                        userName += chars[i];
                        i++;
                    }
                    i++;

                    newsItem.User = UnitOfWork.UserRepository.Get(u => u.Login == userName).FirstOrDefault();
                    //title
                    string title = null;
                    while (chars[i] != '|')
                    {
                        title += chars[i];
                        i++;
                    }
                    i++;

                    newsItem.Title = title;
                    //brief
                    string brief = null;
                    while (chars[i] != '|')
                    {
                        brief += chars[i];
                        i++;
                    }
                    i++;

                    newsItem.Brief = brief;
                    // message
                    string message = null;
                    while (chars[i] != '|')
                    {
                        message += chars[i];
                        i++;
                    }
                    i++;

                    newsItem.Message = message;
                    // attach
                    while (chars[i] != '|')
                    {
                        id += chars[i];
                        i++;
                    }
                    i++;

                    // files
                    while (true)
                    {
                        if (chars[i] == '\\' && chars[i + 1] == '|' && chars[i + 2] == '|')
                        {
                            break;
                        }
                        i++;
                    }
                    i += 3;
                    //i++;

                    // reads
                    string reads = null;


                    while (chars[i] != '|')
                    {
                        reads += chars[i];
                        i++;
                    }
                    i++;

                    newsItem.Reads = int.Parse(reads);
                    // rating
                    string rating = null;
                    while (chars[i] != '|')
                    {
                        rating += chars[i];
                        i++;
                    }
                    i++;

                    newsItem.Rating = float.Parse(rating);
                    // rate_num
                    string ratingNumbers = null;
                    while (chars[i] != '|')
                    {
                        ratingNumbers += chars[i];
                        i++;
                    }
                    i++;

                    newsItem.RatingNumbers = int.Parse(ratingNumbers);
                    // rate sum
                    string ratingSumm = null;
                    while (chars[i] != '|')
                    {
                        ratingSumm += chars[i];
                        i++;
                    }
                    i++;

                    newsItem.RatingSumm = int.Parse(ratingSumm);
                    //rate ip
                    while (chars[i] != '|')
                    {
                        reads += chars[i];
                        i++;
                    }
                    i++;

                    // other 1
                    while (chars[i] != '|')
                    {
                        reads += chars[i];
                        i++;
                    }
                    i++;

                    // other 2 SOURCE
                    string source = null;
                    while (chars[i] != '|')
                    {
                        source += chars[i];
                        i++;
                    }
                    newsItem.Source = source;
                    i++;

                    // other 3
                    while (chars[i] != '|')
                    {
                        reads += chars[i];
                        i++;
                    }
                    i++;

                    // other 4
                    while (chars[i] != '|')
                    {
                        reads += chars[i];
                        i++;
                    }
                    i++;

                    // other 5
                    while (chars[i] != '|')
                    {
                        reads += chars[i];
                        i++;
                    }
                    i++;
                    // other6
                    while (chars[i] != '|')
                    {
                        // reads += chars[i];
                        i++;
                    }
                    i++;

                    // uid
                    while (chars[i] != '|')
                    {
                        // reads += chars[i];
                        i++;
                    }
                    i++;

                    // subscr
                    while (chars[i] != '|')
                    {
                        // reads += chars[i];
                        i++;
                    }
                    i++;

                    // last modified
                    string lastDate = null;
                    while (char.IsDigit(chars[i]))// != '|' || chars[i] != '\\'))
                    {
                        lastDate += chars[i];
                        i++;
                    }
                    //i++;

                    newsItem.LastModifiedUTC = long.Parse(lastDate);
                    UnitOfWork.NewsItemRepository.Add(newsItem);
                    // while (chars[i] != 10)
                    //  {
                    //       i++;
                    //  }
                }
                UnitOfWork.Save();
            }
        }

        private static void UpdateBlogCategory()
        {
            using (FileStream fs = new FileStream(@"C:\\bl_bl.txt", FileMode.Open))
            {
                byte[] data = new byte[fs.Length];
                fs.Read(data, 0, Convert.ToInt32(fs.Length));

                char[] chars = Encoding.UTF8.GetString(data).ToCharArray();
                for (int i = 0; i < chars.Length; i++)
                {
                    BlogCategory blogCategory = new BlogCategory();
                    // id
                    string id = null;
                    while (chars[i] != '|')
                    {
                        id += chars[i];
                        i++;
                    }
                    i++;
                    blogCategory.Id = int.Parse(id);
                    // position
                    string position = null;
                    while (chars[i] != '|')
                    {
                        position += chars[i];
                        i++;
                    }
                    i++;
                    blogCategory.Position = int.Parse(position);
                    // count
                    string count = null;
                    while (chars[i] != '|')
                    {
                        count += chars[i];
                        i++;
                    }
                    i++;
                    blogCategory.ItemsCount = int.Parse(count);

                    // name
                    while (chars[i] != '|')
                    {
                        blogCategory.Name += chars[i];
                        i++;
                    }
                    i++;
                    // description
                    i++;
                    // url
                    if (chars[i] != '|')
                    {
                        while (chars[i] != '|')
                        {
                            blogCategory.UrlPath += chars[i];
                            i++;
                        }
                    }
                    i++;

                    UnitOfWork.BlogCategoryRepository.Add(blogCategory);

                }
                UnitOfWork.Save();
            }
        }

        private static void UpdateNewsCategory()
        {
            using (FileStream fs = new FileStream(@"C:\\nw_nw.txt", FileMode.Open))
            {
                byte[] data = new byte[fs.Length];
                fs.Read(data, 0, Convert.ToInt32(fs.Length));

                char[] chars = Encoding.UTF8.GetString(data).ToCharArray();
                for (int i = 0; i < chars.Length; i++)
                {
                    NewsCategory newsCategory = new NewsCategory();
                    // id
                    string id = null;
                    while (chars[i] != '|')
                    {
                        id += chars[i];
                        i++;
                    }
                    i++;
                    newsCategory.Id = int.Parse(id);
                    // position
                    string position = null;
                    while (chars[i] != '|')
                    {
                        position += chars[i];
                        i++;
                    }
                    i++;
                    newsCategory.Position = int.Parse(position);
                    // count
                    string count = null;
                    while (chars[i] != '|')
                    {
                        count += chars[i];
                        i++;
                    }
                    i++;
                    newsCategory.ItemsCount = int.Parse(count);

                    // name
                    while (chars[i] != '|')
                    {
                        newsCategory.Name += chars[i];
                        i++;
                    }
                    i++;
                    
                    // url
                    if (chars[i] == '|')
                    {
                        i++;
                        while (chars[i] != '|')
                        {
                            newsCategory.UrlPath += chars[i];
                            i++;
                        }
                        i++;
                    }
                    UnitOfWork.NewsCategoryRepository.Add(newsCategory);
                    
                }
                UnitOfWork.Save();
            }
        }
    }
}
