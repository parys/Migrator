using System;
using Common.Entities;
using DAL.models;

namespace DAL
{
    /// <summary>
    /// Maintains a list of repositories affected by a business transaction and coordinates 
    /// the writing out of changes and the resolution of concurrency problems.
    /// </summary>
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly QasContext context = new QasContext();

        private IGenericRepository<User> userRepository;
        private IGenericRepository<BlogItem> blogItemRepository;
        private IGenericRepository<NewsItem> newsItemRepository;
        private IGenericRepository<BlogCategory> blogCategoryRepository;
        private IGenericRepository<NewsCategory> newsCategoryRepository;
        private IGenericRepository<Comment> commentRepository;
       // private IGenericRepository<AimPriority> aimPriorityRepository;
       // private IGenericRepository<AimAchievementQuality> aimAchievementQualityRepository;
      //  private IGenericRepository<ReviewRequest> reviewRequestsRepository;
      //  private IGenericRepository<Review> reviewRepository;
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

        public IGenericRepository<Comment> CommentRepository
        {
            get { return commentRepository ?? (commentRepository = new GenericRepository<Comment>(context)); }
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