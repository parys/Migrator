using System;
using DAL;
using DAL.models;

namespace MyLiverpoolSite.DataAccessLayer
{
    /// <summary>
    /// Maintains a list of repositories affected by a business transaction and coordinates 
    /// the writing out of changes and the resolution of concurrency problems.
    /// </summary>
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly LiverpoolContext context = new LiverpoolContext();

        private IGenericRepository<User> userRepository;
        private IGenericRepository<BlogItem> blogItemRepository;
        private IGenericRepository<NewsItem> newsItemRepository;
        private IGenericRepository<BlogCategory> blogCategoryRepository;
        private IGenericRepository<NewsCategory> newsCategoryRepository;
        private IGenericRepository<BlogComment> blogCommentRepository;
        private IGenericRepository<NewsComment> newsCommentRepository;
        private IGenericRepository<ForumSection> forumSectionRepository;
        private IGenericRepository<ForumTheme> forumThemeRepository;
        private IGenericRepository<ForumSubsection> forumSubsectionRepository;
        private IGenericRepository<ForumMessage> forumMessageRepository;
      //  private IGenericRepository<Room> roomRepository;
      //  private IGenericRepository<Workplace> workplaceRepository;
      //  private IGenericRepository<StatisticsItem> statisticsItemRepository;
      //  private IGenericRepository<FrequentlyAskedQuestionsItem> frequentlyAskedQuestionsItemRepository;
      //  private IGenericRepository<AboutElement> aboutElement;

        /// <summary>
        /// Return userRepository.
        /// </summary>
        public IGenericRepository<User> UserRepository
        {
            get { return userRepository ?? (userRepository = new GenericRepository<User>(context)); }
        }

        /// <summary>
        /// Return qualificationRepository.
        /// </summary>
        public IGenericRepository<BlogItem> BlogItemRepository
        {
            get {
                return blogItemRepository ??
                       (blogItemRepository = new GenericRepository<BlogItem>(context));
            }
        }

        public IGenericRepository<BlogCategory> BlogCategoryRepository
        {
            get
            {
                return blogCategoryRepository ??
                       (blogCategoryRepository = new GenericRepository<BlogCategory>(context));
            }
        }

        public IGenericRepository<NewsCategory> NewsCategoryRepository
        {
            get
            {
                return newsCategoryRepository ??
                       (newsCategoryRepository = new GenericRepository<NewsCategory>(context));
            }
        }

        /// <summary>
        /// Return roleRepository.
        /// </summary>
        public IGenericRepository<NewsItem> NewsItemRepository
        {
            get { return newsItemRepository ?? (newsItemRepository = new GenericRepository<NewsItem>(context)); }
        }

        public IGenericRepository<BlogComment> BlogCommentRepository
        {
            get { return blogCommentRepository ?? (blogCommentRepository = new GenericRepository<BlogComment>(context)); }
        }
        public IGenericRepository<NewsComment> NewsCommentRepository
        {
            get { return newsCommentRepository ?? (newsCommentRepository = new GenericRepository<NewsComment>(context)); }
        }


        public IGenericRepository<ForumSection> ForumSectionRepository
        {
            get { return forumSectionRepository ?? (forumSectionRepository = new GenericRepository<ForumSection>(context)); }
        }
        
        public IGenericRepository<ForumTheme> ForumThemeRepository
        {
            get { return forumThemeRepository ?? (forumThemeRepository = new GenericRepository<ForumTheme>(context)); }
        }
        public IGenericRepository<ForumSubsection> ForumSubsectionRepository
        {
            get { return forumSubsectionRepository ?? (forumSubsectionRepository = new GenericRepository<ForumSubsection>(context)); }
        }
        public IGenericRepository<ForumMessage> ForumMessageRepository
        {
            get { return forumMessageRepository ?? (forumMessageRepository = new GenericRepository<ForumMessage>(context)); }
        }

        /// <summary>
        /// Saves changes to shared data source.
        /// </summary>
        public void Save()
        {
            context.SaveChanges();
        }

        private bool disposed;

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            disposed = true;
        }

        /// <summary>
        /// The release of resources.
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}