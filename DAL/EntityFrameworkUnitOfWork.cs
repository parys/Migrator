using System.Data.Entity;
using Common.Entities;

namespace DAL
{
    /// <summary>
    /// Singleton class that aggregates multiple repositories so that they all share a single database context.
    /// That way, when a unit of work is complete you can call the Commit method on that instance of the context
    /// and be assured that all related changes will be coordinated.
    /// </summary>
    public class EntityFrameworkUnitOfWork : DbContext, IUnitOfWork
    {
        private readonly EntityFrameworkGenericRepository<User> userRepository;
        private readonly EntityFrameworkGenericRepository<Qualification> qualificationRepository;
        private readonly EntityFrameworkGenericRepository<Role> roleRepository;
        private readonly EntityFrameworkGenericRepository<Request> requestRepository;
        private readonly EntityFrameworkGenericRepository<Aim> aimRepository;
        private readonly EntityFrameworkGenericRepository<AimComment> aimUserCommentsRepository;
        private readonly EntityFrameworkGenericRepository<AimPriority> aimPriorityRepository;
        private readonly EntityFrameworkGenericRepository<AimAchievementQuality> aimAchievementQualityRepository;
        private readonly EntityFrameworkGenericRepository<ReviewRequest> reviewRequestsRepository;

        private readonly EntityFrameworkGenericRepository<Review> reviewRepository;
        private readonly EntityFrameworkGenericRepository<Room> roomRepository;
        private readonly EntityFrameworkGenericRepository<Workplace> workplaceRepository;
        private readonly EntityFrameworkGenericRepository<StatisticsItem> statisticsItemRepository;

        private readonly EntityFrameworkGenericRepository<FrequentlyAskedQuestionsItem>
            frequentlyAskedQuestionsItemRepository;

        /// <summary>
        /// Represents a requests set that is used to perform create, read, update, and delete operations
        /// </summary>
        public DbSet<Request> Requests { get; set; }

        /// <summary>
        /// Represents a users set that is used to perform create, read, update, and delete operations
        /// </summary>
        public DbSet<User> Users { get; set; }

        /// <summary>
        /// Represents a qualifications set that is used to perform create, read, update, and delete operations
        /// </summary>
        public DbSet<Qualification> Qualifications { get; set; }

        /// <summary>
        /// Represents a roles set that is used to perform create, read, update, and delete operations
        /// </summary>
        public DbSet<Role> Roles { get; set; }

        /// <summary>
        /// Represents a aims set that is used to perform create, read, update, and delete operations
        /// </summary>
        public DbSet<Aim> Aims { get; set; }

        /// <summary>
        /// Represents a aim user commentaries set that is used to perform create, read, update, and delete operations
        /// </summary>
        public DbSet<AimComment> AimUserComments { get; set; }

        /// <summary>
        /// Represents a aim priorities set that is used to perform create, read, update, and delete operations
        /// </summary>
        public DbSet<AimPriority> AimPriorities { get; set; }

        /// <summary>
        /// Represents a aim achievement qualities set that is used to perform create, read, update, and delete operations
        /// </summary>
        public DbSet<AimAchievementQuality> AimAchievementQualities { get; set; }

        /// <summary>
        /// Represents a review set that is used to perform create, read, update, and delete operations
        /// </summary>
        public DbSet<Review> Reviews { get; set; }

        public DbSet<Room> Rooms { get; set; }

        public DbSet<Workplace> Workplaces { get; set; }

        /// <summary>
        /// Represents a review requests set that is used to perform create, read, update, and delete operations
        /// </summary>
        public DbSet<ReviewRequest> ReviewRequests { get; set; }

        /// <summary>
        /// Represents a statistics items set, that is used for collect user visits
        /// </summary>
        public DbSet<StatisticsItem> StatisticsItems { get; set; }

        /// <summary>
        /// Represents a FrequentlyAskedQuestions item set, that contains faq
        /// </summary>
        public DbSet<FrequentlyAskedQuestionsItem> FrequentlyAskedQuestionsItem { get; set; }

        /// <summary>
        /// Initializes base constructor with connection string that provides information on database's whereabouts.
        /// </summary>
        public EntityFrameworkUnitOfWork()
            : base()
        {
            Database.SetInitializer(new DatabaseInitializer());
            userRepository = new EntityFrameworkGenericRepository<User>(Users);
            qualificationRepository = new EntityFrameworkGenericRepository<Qualification>(Qualifications);
            roleRepository = new EntityFrameworkGenericRepository<Role>(Roles);
            requestRepository = new EntityFrameworkGenericRepository<Request>(Requests);
            aimRepository = new EntityFrameworkGenericRepository<Aim>(Aims);
            aimUserCommentsRepository = new EntityFrameworkGenericRepository<AimComment>(AimUserComments);
            aimPriorityRepository = new EntityFrameworkGenericRepository<AimPriority>(AimPriorities);
            aimAchievementQualityRepository = new EntityFrameworkGenericRepository<AimAchievementQuality>(AimAchievementQualities);
            reviewRepository = new EntityFrameworkGenericRepository<Review>(Reviews);
            reviewRequestsRepository = new EntityFrameworkGenericRepository<ReviewRequest>(ReviewRequests);
            roomRepository = new EntityFrameworkGenericRepository<Room>(Rooms);
            workplaceRepository = new EntityFrameworkGenericRepository<Workplace>(Workplaces);
            statisticsItemRepository = new EntityFrameworkGenericRepository<StatisticsItem>(StatisticsItems);
            frequentlyAskedQuestionsItemRepository = new EntityFrameworkGenericRepository<FrequentlyAskedQuestionsItem>(FrequentlyAskedQuestionsItem);
        }


        /// <summary>
        /// Return requestRepository
        /// </summary>
        public IGenericRepository<Request> RequestRepository
        {
            get { return requestRepository; }
        }

        /// <summary>
        /// Return userRepository
        /// </summary>
        public IGenericRepository<User> UserRepository
        {
            get { return userRepository; }
        }

        /// <summary>
        /// Return qualificationRepository
        /// </summary>
        public IGenericRepository<Qualification> QualificationRepository
        {
            get { return qualificationRepository; }
        }

        /// <summary>
        /// Return roleRepository
        /// </summary>
        public IGenericRepository<Role> RoleRepository
        {
            get { return roleRepository; }
        }

        /// <summary>
        /// Return aimRepository
        /// </summary>
        public IGenericRepository<Aim> AimRepository
        {
            get { return aimRepository; }
        }

        /// <summary>
        /// Return aimUserCommentRepository
        /// </summary>
        public IGenericRepository<AimComment> AimUserCommentRepository
        {
            get { return aimUserCommentsRepository; }
        }

        /// <summary>
        /// Return aimPriorityRepository
        /// </summary>
        public IGenericRepository<AimPriority> AimPriorityRepository
        {
            get { return aimPriorityRepository; }
        }

        /// <summary>
        /// Return aimAchievementQualityRepository
        /// </summary>
        public IGenericRepository<AimAchievementQuality> AimAchievementQualityRepository
        {
            get { return aimAchievementQualityRepository; }
        }

        /// <summary>
        /// Return reviewRepository
        /// </summary>
        public IGenericRepository<Review> ReviewRepository
        {
            get { return reviewRepository; }
        }

        public IGenericRepository<Room> RoomRepository
        {
            get { return roomRepository; }
        }

        public IGenericRepository<Workplace> WorkplaceRepository
        {
            get { return workplaceRepository; }
        }

        /// <summary>
        /// Return reviewRequestsRepository
        /// </summary>
        public IGenericRepository<ReviewRequest> ReviewRequestsRepository
        {
            get { return reviewRequestsRepository; }
        }

        /// <summary>
        /// Return statisticsItemRepository
        /// </summary>
        public IGenericRepository<StatisticsItem> StatisticsItemRepository
        {
            get { return statisticsItemRepository; }
        }

        /// <summary>
        /// Return frequentlyAskedQuestionsItemRepository
        /// </summary>
        public IGenericRepository<FrequentlyAskedQuestionsItem> FrequentlyAskedQuestionsItemRepository
        {
            get { return frequentlyAskedQuestionsItemRepository; }
        }

        /// <summary>
        /// Saves changes to database.
        /// </summary>
        public void Commit()
        {
            SaveChanges();
        }

        /// <summary>
        /// Configures entity relationships using Fluent API.
        /// </summary>
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                        .HasOptional(user => user.Coach)
                        .WithMany();

            modelBuilder.Entity<User>()
                        .HasMany(user => user.Roles)
                        .WithMany();

            modelBuilder.Entity<User>()
                        .HasOptional(user => user.Qualification)
                        .WithMany();

            modelBuilder.Entity<User>()
                        .HasOptional(user => user.ResourceManager)
                        .WithMany();

            modelBuilder.Entity<User>()
                        .HasOptional(user => user.Request)
                        .WithOptionalDependent();

            modelBuilder.Entity<User>()
                        .HasOptional(user => user.Workplace)
                        .WithOptionalPrincipal();

            modelBuilder.Entity<User>()
                        .HasMany(user => user.Aims)
                        .WithOptional();

            modelBuilder.Entity<User>()
                        .HasMany(user => user.CareerGrowthDayHistoryEntries)
                        .WithOptional();

            modelBuilder.Entity<Aim>()
                        .HasRequired(a => a.User)
                        .WithMany(u => u.Aims);

            modelBuilder.Entity<Aim>()
                        .HasMany(aim => aim.AimComments)
                        .WithOptional();

            modelBuilder.Entity<AimComment>()
                        .HasRequired(a => a.Author)
                        .WithMany();

            modelBuilder.Entity<User>()
                        .HasOptional(u => u.ReviewRequest)
                        .WithOptionalPrincipal();

            base.OnModelCreating(modelBuilder);
        }
    }
}
