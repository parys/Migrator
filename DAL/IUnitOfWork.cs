﻿using DAL.models;
using MyLiverpoolSite.DataAccessLayer;

namespace DAL
{
    /// <summary>
    /// Maintains a list of repositories affected by a business transaction and coordinates 
    /// the writing out of changes and the resolution of concurrency problems.
    /// </summary>
    public interface IUnitOfWork
    {
        /// <summary>
        /// Provides access to user repository.
        /// </summary>
        IGenericRepository<User> UserRepository { get; }

        /// <summary>
        /// Provides access to qualification repository.
        /// </summary>
        IGenericRepository<BlogItem> BlogItemRepository { get; }

        /// <summary>
        /// Provides access to role repository.
        /// </summary>
        IGenericRepository<NewsItem> NewsItemRepository { get; }

        /// <summary>
        /// Provides access to request repository.
        /// </summary>
        IGenericRepository<BlogCategory> BlogCategoryRepository { get; }

        /// <summary>
        /// Provides access to aim repository.
        /// </summary>
        IGenericRepository<NewsCategory> NewsCategoryRepository { get; }


        IGenericRepository<BlogComment> BlogCommentRepository { get; }

        IGenericRepository<NewsComment> NewsCommentRepository { get; }

        /// <summary>
        /// Provides access to aim priority repository.
        /// </summary>
        IGenericRepository<ForumSection> ForumSectionRepository { get; }

        /// <summary>
        /// Provides access to aim achievment quality repository.
        /// </summary>
        IGenericRepository<ForumTheme> ForumThemeRepository { get; }

        /// <summary>
        /// Provides access to review repository.
        /// </summary>
        IGenericRepository<ForumSubsection> ForumSubsectionRepository { get; }

        /// <summary>
        /// Provides access to review requests repository.
        /// </summary>
        IGenericRepository<ForumMessage> ForumMessageRepository { get; }

        IGenericRepository<Role> RoleRepository { get; }
        IGenericRepository<RoleClaim> RoleClaimRepository { get; }
        IGenericRepository<UserClaim> UserClaimRepository { get; }
        IGenericRepository<UserLogin> UserLoginRepository { get; }

        /// <summary>
        /// Provides access to room repository.
        /// </summary>
      //  IGenericRepository<Room> RoomRepository { get; }

        /// <summary>
        /// Provides access to workplace repository.
        /// </summary>
    //    IGenericRepository<Workplace> WorkplaceRepository { get; }

        /// <summary>
        /// Provides access to statistics items repository.
        /// </summary>
     //   IGenericRepository<StatisticsItem> StatisticsItemRepository { get; }

        /// <summary>
        /// Provide access to FrequentlyAskedQuestionsItem repository.
        /// </summary>
     //   IGenericRepository<FrequentlyAskedQuestionsItem> FrequentlyAskedQuestionsItemRepository { get; }

        /// <summary>
        /// Provide access to AboutItem repository.
        /// </summary>
     //   IGenericRepository<AboutElement> AboutRepository { get; }

        /// <summary>
        /// Saves changes to shared data source.
        /// </summary>
        void Save();

        /// <summary>
        /// The release of resources.
        /// </summary>
        void Dispose();
    }
}
