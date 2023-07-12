using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;

namespace MiniProject_LinkedIn.Models
{
    public class UserContext:DbContext
    {
        public UserContext()
        {

        }
        public UserContext(DbContextOptions<UserContext> options):base (options)
        {
        }
            public DbSet<User_Information> UserInformation { get; set; }
            public DbSet<Experience> Experience { get; set; }
            public DbSet<Project> Project { get; set; }
            public DbSet<Skill> Skill { get; set; }
            public DbSet<UserConnections> UserConnections { get; set; }
            public DbSet<User_Post> User_Post { get; set; }
            public DbSet<PostLikes> PostLikes { get; set; }
            public DbSet<PostComments> PostComments { get; set; }
            public DbSet<Objects> Objects { get; set; }
            public DbSet<ParentObject>ParentObjects { get; set; }
            public DbSet<ObjectType> ObjectTypes { get; set; }
            public DbSet<View1> view1 { get; set; }
            [JsonIgnore]
        public DbSet<Locations> Locations { get; set; }
            [JsonIgnore]
        public DbSet<Invitations> Invitations { get; set; }
            [JsonIgnore]             
            public DbSet<Connection_sPost> Connection_sPosts { get; set; }
        [JsonIgnore]
        public DbSet<CountPostLike> CountPostLikes { get; set; }
        [JsonIgnore]
        public DbSet<OwnPosts> OwnPosts { get; set; }
        [JsonIgnore]
        public DbSet<My_Network> My_Network { get; set; }
        [JsonIgnore]
        public DbSet<CheckOwnPostLike> CheckOwnPostLikes { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionbuilder)
        {
            optionbuilder.UseSqlServer("Server=PC0404\\MSSQL2019;Database=LinkedInDB;Trusted_Connection=True;" +
                "TrustServerCertificate=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
            modelBuilder.Entity<User_Information>()
                   .HasOne(m => m.UserInformation1)
                   .WithOne()
                   .HasForeignKey<User_Information>(m => m.CreatedById)
                   .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<User_Information>()
               .HasOne(m => m.UserInformation2)
               .WithOne()
               .HasForeignKey<User_Information>(m => m.ModifiedById)
               .OnDelete(DeleteBehavior.Restrict);




            modelBuilder.Entity<UserConnections>()
                    .HasOne(m => m.UserInformation1)
                    .WithMany(t => t.UserConnections1)
                    .HasForeignKey(m => m.User_ID)
                    .OnDelete(DeleteBehavior.Restrict);    
                modelBuilder.Entity<UserConnections>()
                   .HasOne(m => m.UserInformation2)
                   .WithMany(t => t.UserConnections2)
                   .HasForeignKey(m => m.ConnectedUser_ID)
                   .OnDelete(DeleteBehavior.Restrict);
                modelBuilder.Entity<UserConnections>()
                   .HasOne(m => m.UserInformation3)
                   .WithMany(t => t.UserConnections3)
                   .HasForeignKey(m => m.CreatedById)
                   .OnDelete(DeleteBehavior.Restrict);
                modelBuilder.Entity<UserConnections>()
                        .HasOne(m => m.UserInformation4)
                        .WithMany(t => t.UserConnections4)
                        .HasForeignKey(m => m.ModifiedById)
                        .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<LicansesCertificate>()
                   .HasOne(m => m.UserInformation1)
                   .WithMany(t => t.LicansesCertificate1)
                   .HasForeignKey(m => m.User_ID)
                   .OnDelete(DeleteBehavior.Restrict);
               modelBuilder.Entity<LicansesCertificate>()
                     .HasOne(m => m.UserInformation2)
                     .WithMany(t => t.LicansesCertificate2)
                     .HasForeignKey(m => m.CreatedById)
                     .OnDelete(DeleteBehavior.Restrict);
               modelBuilder.Entity<LicansesCertificate>()
                     .HasOne(m => m.UserInformation3)
                     .WithMany(t => t.LicansesCertificate3)
                     .HasForeignKey(m => m.ModifiedById)
                     .OnDelete(DeleteBehavior.Restrict);


            modelBuilder.Entity<User_Post>()
                   .HasOne(m => m.UserInformation)
                   .WithMany(t => t.user_Posts)
                   .HasForeignKey(m => m.User_Id)
                   .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<User_Post>()
                    .HasOne(m => m.UserInformation1)
                    .WithMany(t => t.user_Posts1)
                    .HasForeignKey(m => m.CreatedById)
                    .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<User_Post>()
                    .HasOne(m => m.UserInformation2)
                    .WithMany(t => t.user_Posts2)
                    .HasForeignKey(m => m.ModifiedById)
                    .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<PostLikes>()
                .HasOne(m => m.UserInformation)
                .WithMany(t => t.postLikes)
                .HasForeignKey(m => m.User_Id)
                .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<PostLikes>()
                    .HasOne(m => m.UserInformation1)
                    .WithMany(t => t.postLikes1)
                    .HasForeignKey(m => m.CreatedById)
                    .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<PostLikes>()
                    .HasOne(m => m.UserInformation2)
                    .WithMany(t => t.postLikes2)
                    .HasForeignKey(m => m.ModifiedById)
                    .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<PostComments>()
              .HasOne(m => m.UserInformation)
              .WithMany(t => t.PostComments)
              .HasForeignKey(m => m.User_Id)
              .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<PostComments>()
                    .HasOne(m => m.UserInformation1)
                    .WithMany(t => t.PostComments1)
                    .HasForeignKey(m => m.CreatedById)
                    .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<PostComments>()
                    .HasOne(m => m.UserInformation2)
                    .WithMany(t => t.PostComments2)
                    .HasForeignKey(m => m.ModifiedById)
                    .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<CommentLikes>()
               .HasOne(m => m.UserInformation)
               .WithMany(t => t.commentLikes)
               .HasForeignKey(m => m.User_ID)
               .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<CommentLikes>()
                    .HasOne(m => m.UserInformation1)
                    .WithMany(t => t.commentLikes1)
                    .HasForeignKey(m => m.CreatedById)
                    .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<CommentLikes>()
                    .HasOne(m => m.UserInformation2)
                    .WithMany(t => t.commentLikes2)
                    .HasForeignKey(m => m.ModifiedById)
                    .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Project>()
            .HasOne(m => m.UserInformation)
            .WithMany(t => t.Project)
            .HasForeignKey(m => m.User_Id)
            .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Project>()
                    .HasOne(m => m.UserInformation1)
                    .WithMany(t => t.Project1)
                    .HasForeignKey(m => m.CreatedById)
                    .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Project>()
                    .HasOne(m => m.UserInformation2)
                    .WithMany(t => t.Project2)
                    .HasForeignKey(m => m.ModifiedById)
                    .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Skill>()
                    .HasOne(m => m.UserInformation)
                    .WithMany(t => t.skills)
                    .HasForeignKey(m => m.User_Id)
                    .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Skill>()
                    .HasOne(m => m.UserInformation1)
                    .WithMany(t => t.skills1)
                    .HasForeignKey(m => m.CreatedById)
                    .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Skill>()
                    .HasOne(m => m.UserInformation2)
                    .WithMany(t => t.skills2)
                    .HasForeignKey(m => m.ModifiedById)
                    .OnDelete(DeleteBehavior.Restrict);


            modelBuilder.Entity<Experience>()
                    .HasOne(m => m.UserInformation)
                    .WithMany(t => t.experiences)
                    .HasForeignKey(m => m.User_Id)
                    .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Experience>()
                    .HasOne(m => m.UserInformation1)
                    .WithMany(t => t.experiences1)
                    .HasForeignKey(m => m.CreatedById)
                    .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Experience>()
                    .HasOne(m => m.UserInformation2)
                    .WithMany(t => t.experiences2)
                    .HasForeignKey(m => m.ModifiedById)
                    .OnDelete(DeleteBehavior.Restrict);

           




        }
    }
}
