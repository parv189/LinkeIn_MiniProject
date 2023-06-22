﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MiniProject_LinkedIn.Models;

#nullable disable

namespace MiniProject_LinkedIn.Migrations
{
    [DbContext(typeof(UserContext))]
    [Migration("20230621120255_init2")]
    partial class init2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MiniProject_LinkedIn.Models.CommentLikes", b =>
                {
                    b.Property<int>("CommentLike_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CommentLike_Id"));

                    b.Property<DateTime?>("CreatedByDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("CreatedById")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ModifiedByDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("ModifiedById")
                        .HasColumnType("int");

                    b.Property<int?>("PostComment_Id")
                        .HasColumnType("int");

                    b.Property<int?>("User_ID")
                        .HasColumnType("int");

                    b.HasKey("CommentLike_Id");

                    b.HasIndex("CreatedById");

                    b.HasIndex("ModifiedById");

                    b.HasIndex("PostComment_Id");

                    b.HasIndex("User_ID");

                    b.ToTable("CommentLikes");
                });

            modelBuilder.Entity("MiniProject_LinkedIn.Models.Company", b =>
                {
                    b.Property<int>("Company_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Company_Id"));

                    b.Property<string>("Company_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedByDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("CreatedById")
                        .HasColumnType("int");

                    b.Property<int?>("Location_Id")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ModifiedByDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("ModifiedById")
                        .HasColumnType("int");

                    b.HasKey("Company_Id");

                    b.ToTable("Company");
                });

            modelBuilder.Entity("MiniProject_LinkedIn.Models.Experience", b =>
                {
                    b.Property<int>("Exp_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Exp_Id"));

                    b.Property<int?>("Company_Id")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedByDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("CreatedById")
                        .HasColumnType("int");

                    b.Property<string>("Employment_Type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("End_Date")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ModifiedByDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("ModifiedById")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Start_Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("User_Id")
                        .HasColumnType("int");

                    b.HasKey("Exp_Id");

                    b.HasIndex("Company_Id")
                        .IsUnique()
                        .HasFilter("[Company_Id] IS NOT NULL");

                    b.HasIndex("CreatedById");

                    b.HasIndex("ModifiedById");

                    b.HasIndex("User_Id");

                    b.ToTable("Experience");
                });

            modelBuilder.Entity("MiniProject_LinkedIn.Models.LicansesCertificate", b =>
                {
                    b.Property<int>("LC_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LC_Id"));

                    b.Property<DateTime?>("CreatedByDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("CreatedById")
                        .HasColumnType("int");

                    b.Property<string>("LC_Details")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LC_Link")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LC_Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ModifiedByDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("ModifiedById")
                        .HasColumnType("int");

                    b.Property<int?>("User_ID")
                        .HasColumnType("int");

                    b.HasKey("LC_Id");

                    b.HasIndex("CreatedById");

                    b.HasIndex("ModifiedById");

                    b.HasIndex("User_ID");

                    b.ToTable("LicansesCertificate");
                });

            modelBuilder.Entity("MiniProject_LinkedIn.Models.Locations", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Locations");
                });

            modelBuilder.Entity("MiniProject_LinkedIn.Models.ObjectType", b =>
                {
                    b.Property<int>("ObjectType_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ObjectType_Id"));

                    b.Property<DateTime?>("CreatedByDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("CreatedById")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ModifiedByDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("ModifiedById")
                        .HasColumnType("int");

                    b.Property<string>("ObjectType_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ObjectType_Id");

                    b.ToTable("ObjectTypes");
                });

            modelBuilder.Entity("MiniProject_LinkedIn.Models.Objects", b =>
                {
                    b.Property<int>("Object_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Object_Id"));

                    b.Property<DateTime?>("CreatedByDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("CreatedById")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ModifiedByDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("ModifiedById")
                        .HasColumnType("int");

                    b.Property<int?>("ObjectType_Id")
                        .HasColumnType("int");

                    b.Property<string>("Object_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Object_Id");

                    b.HasIndex("ObjectType_Id");

                    b.ToTable("Objects");
                });

            modelBuilder.Entity("MiniProject_LinkedIn.Models.ParentObject", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("CreatedByDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("CreatedById")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ModifiedByDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("ModifiedById")
                        .HasColumnType("int");

                    b.Property<int?>("Parent_Id")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Parent_Id")
                        .IsUnique()
                        .HasFilter("[Parent_Id] IS NOT NULL");

                    b.ToTable("ParentObjects");
                });

            modelBuilder.Entity("MiniProject_LinkedIn.Models.PostComments", b =>
                {
                    b.Property<int>("PostComment_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PostComment_Id"));

                    b.Property<string>("Comment_Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedByDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("CreatedById")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ModifiedByDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("ModifiedById")
                        .HasColumnType("int");

                    b.Property<int?>("Post_Id")
                        .HasColumnType("int");

                    b.Property<int?>("User_Id")
                        .HasColumnType("int");

                    b.HasKey("PostComment_Id");

                    b.HasIndex("CreatedById");

                    b.HasIndex("ModifiedById");

                    b.HasIndex("Post_Id");

                    b.HasIndex("User_Id");

                    b.ToTable("PostComments");
                });

            modelBuilder.Entity("MiniProject_LinkedIn.Models.PostLikes", b =>
                {
                    b.Property<int>("PostLike_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PostLike_Id"));

                    b.Property<DateTime?>("CreatedByDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("CreatedById")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ModifiedByDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("ModifiedById")
                        .HasColumnType("int");

                    b.Property<int?>("Post_Id")
                        .HasColumnType("int");

                    b.Property<int?>("User_Id")
                        .HasColumnType("int");

                    b.HasKey("PostLike_Id");

                    b.HasIndex("CreatedById");

                    b.HasIndex("ModifiedById");

                    b.HasIndex("Post_Id");

                    b.HasIndex("User_Id");

                    b.ToTable("PostLikes");
                });

            modelBuilder.Entity("MiniProject_LinkedIn.Models.Project", b =>
                {
                    b.Property<int>("Project_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Project_Id"));

                    b.Property<DateTime?>("CreatedByDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("CreatedById")
                        .HasColumnType("int");

                    b.Property<DateTime?>("End_Date")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ModifiedByDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("ModifiedById")
                        .HasColumnType("int");

                    b.Property<string>("Project_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Start_Date")
                        .HasColumnType("datetime2");

                    b.Property<int?>("User_Id")
                        .HasColumnType("int");

                    b.HasKey("Project_Id");

                    b.HasIndex("CreatedById");

                    b.HasIndex("ModifiedById");

                    b.HasIndex("User_Id");

                    b.ToTable("Project");
                });

            modelBuilder.Entity("MiniProject_LinkedIn.Models.Skill", b =>
                {
                    b.Property<int>("Skill_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Skill_Id"));

                    b.Property<DateTime?>("CreatedByDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("CreatedById")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ModifiedByDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("ModifiedById")
                        .HasColumnType("int");

                    b.Property<string>("Skill_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("User_Id")
                        .HasColumnType("int");

                    b.HasKey("Skill_Id");

                    b.HasIndex("CreatedById");

                    b.HasIndex("ModifiedById");

                    b.HasIndex("User_Id");

                    b.ToTable("Skill");
                });

            modelBuilder.Entity("MiniProject_LinkedIn.Models.UserConnections", b =>
                {
                    b.Property<int>("UserConnection_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserConnection_Id"));

                    b.Property<int?>("ConnectedUser_ID")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedByDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("CreatedById")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ModifiedByDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("ModifiedById")
                        .HasColumnType("int");

                    b.Property<int?>("User_ID")
                        .HasColumnType("int");

                    b.HasKey("UserConnection_Id");

                    b.HasIndex("ConnectedUser_ID");

                    b.HasIndex("CreatedById");

                    b.HasIndex("ModifiedById");

                    b.HasIndex("User_ID");

                    b.ToTable("UserConnections");
                });

            modelBuilder.Entity("MiniProject_LinkedIn.Models.User_Information", b =>
                {
                    b.Property<int>("User_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("User_ID"));

                    b.Property<DateTime>("CreatedByDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("CreatedById")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ModifiedByDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("ModifiedById")
                        .HasColumnType("int");

                    b.Property<byte[]>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("PasswordSalt")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("User_Background_photo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("User_Contact_Info")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("User_Current_position")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("User_Education")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("User_Headline")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("User_Industry")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("User_Location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("User_Profile_photo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("User_Summary")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("User_ID");

                    b.HasIndex("CreatedById")
                        .IsUnique()
                        .HasFilter("[CreatedById] IS NOT NULL");

                    b.HasIndex("ModifiedById")
                        .IsUnique()
                        .HasFilter("[ModifiedById] IS NOT NULL");

                    b.ToTable("UserInformation");
                });

            modelBuilder.Entity("MiniProject_LinkedIn.Models.User_Post", b =>
                {
                    b.Property<int>("Post_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Post_Id"));

                    b.Property<DateTime?>("CreatedByDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("CreatedById")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ModifiedByDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("ModifiedById")
                        .HasColumnType("int");

                    b.Property<string>("Photo_Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("User_Id")
                        .HasColumnType("int");

                    b.Property<string>("content")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Post_Id");

                    b.HasIndex("CreatedById");

                    b.HasIndex("ModifiedById");

                    b.HasIndex("User_Id");

                    b.ToTable("User_Post");
                });

            modelBuilder.Entity("MiniProject_LinkedIn.Models.View1", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.HasKey("Id");

                    b.ToTable("View1");
                });

            modelBuilder.Entity("MiniProject_LinkedIn.Models.CommentLikes", b =>
                {
                    b.HasOne("MiniProject_LinkedIn.Models.User_Information", "UserInformation1")
                        .WithMany("commentLikes1")
                        .HasForeignKey("CreatedById")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("MiniProject_LinkedIn.Models.User_Information", "UserInformation2")
                        .WithMany("commentLikes2")
                        .HasForeignKey("ModifiedById")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("MiniProject_LinkedIn.Models.PostComments", "PostComments")
                        .WithMany("CommentLikes")
                        .HasForeignKey("PostComment_Id");

                    b.HasOne("MiniProject_LinkedIn.Models.User_Information", "UserInformation")
                        .WithMany("commentLikes")
                        .HasForeignKey("User_ID")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("PostComments");

                    b.Navigation("UserInformation");

                    b.Navigation("UserInformation1");

                    b.Navigation("UserInformation2");
                });

            modelBuilder.Entity("MiniProject_LinkedIn.Models.Experience", b =>
                {
                    b.HasOne("MiniProject_LinkedIn.Models.Company", "Company")
                        .WithOne("Experience")
                        .HasForeignKey("MiniProject_LinkedIn.Models.Experience", "Company_Id");

                    b.HasOne("MiniProject_LinkedIn.Models.User_Information", "UserInformation1")
                        .WithMany("experiences1")
                        .HasForeignKey("CreatedById")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("MiniProject_LinkedIn.Models.User_Information", "UserInformation2")
                        .WithMany("experiences2")
                        .HasForeignKey("ModifiedById")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("MiniProject_LinkedIn.Models.User_Information", "UserInformation")
                        .WithMany("experiences")
                        .HasForeignKey("User_Id")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("Company");

                    b.Navigation("UserInformation");

                    b.Navigation("UserInformation1");

                    b.Navigation("UserInformation2");
                });

            modelBuilder.Entity("MiniProject_LinkedIn.Models.LicansesCertificate", b =>
                {
                    b.HasOne("MiniProject_LinkedIn.Models.User_Information", "UserInformation2")
                        .WithMany("LicansesCertificate2")
                        .HasForeignKey("CreatedById")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("MiniProject_LinkedIn.Models.User_Information", "UserInformation3")
                        .WithMany("LicansesCertificate3")
                        .HasForeignKey("ModifiedById")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("MiniProject_LinkedIn.Models.User_Information", "UserInformation1")
                        .WithMany("LicansesCertificate1")
                        .HasForeignKey("User_ID")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("UserInformation1");

                    b.Navigation("UserInformation2");

                    b.Navigation("UserInformation3");
                });

            modelBuilder.Entity("MiniProject_LinkedIn.Models.Objects", b =>
                {
                    b.HasOne("MiniProject_LinkedIn.Models.ObjectType", "ObjectType")
                        .WithMany("Objects")
                        .HasForeignKey("ObjectType_Id");

                    b.Navigation("ObjectType");
                });

            modelBuilder.Entity("MiniProject_LinkedIn.Models.ParentObject", b =>
                {
                    b.HasOne("MiniProject_LinkedIn.Models.ObjectType", "ObjectType")
                        .WithOne("ParentObject")
                        .HasForeignKey("MiniProject_LinkedIn.Models.ParentObject", "Parent_Id");

                    b.Navigation("ObjectType");
                });

            modelBuilder.Entity("MiniProject_LinkedIn.Models.PostComments", b =>
                {
                    b.HasOne("MiniProject_LinkedIn.Models.User_Information", "UserInformation1")
                        .WithMany("PostComments1")
                        .HasForeignKey("CreatedById")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("MiniProject_LinkedIn.Models.User_Information", "UserInformation2")
                        .WithMany("PostComments2")
                        .HasForeignKey("ModifiedById")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("MiniProject_LinkedIn.Models.User_Post", "User_Post")
                        .WithMany("PostComments")
                        .HasForeignKey("Post_Id");

                    b.HasOne("MiniProject_LinkedIn.Models.User_Information", "UserInformation")
                        .WithMany("PostComments")
                        .HasForeignKey("User_Id")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("UserInformation");

                    b.Navigation("UserInformation1");

                    b.Navigation("UserInformation2");

                    b.Navigation("User_Post");
                });

            modelBuilder.Entity("MiniProject_LinkedIn.Models.PostLikes", b =>
                {
                    b.HasOne("MiniProject_LinkedIn.Models.User_Information", "UserInformation1")
                        .WithMany("postLikes1")
                        .HasForeignKey("CreatedById")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("MiniProject_LinkedIn.Models.User_Information", "UserInformation2")
                        .WithMany("postLikes2")
                        .HasForeignKey("ModifiedById")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("MiniProject_LinkedIn.Models.User_Post", "User_Post")
                        .WithMany("PostLikes")
                        .HasForeignKey("Post_Id");

                    b.HasOne("MiniProject_LinkedIn.Models.User_Information", "UserInformation")
                        .WithMany("postLikes")
                        .HasForeignKey("User_Id")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("UserInformation");

                    b.Navigation("UserInformation1");

                    b.Navigation("UserInformation2");

                    b.Navigation("User_Post");
                });

            modelBuilder.Entity("MiniProject_LinkedIn.Models.Project", b =>
                {
                    b.HasOne("MiniProject_LinkedIn.Models.User_Information", "UserInformation1")
                        .WithMany("Project1")
                        .HasForeignKey("CreatedById")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("MiniProject_LinkedIn.Models.User_Information", "UserInformation2")
                        .WithMany("Project2")
                        .HasForeignKey("ModifiedById")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("MiniProject_LinkedIn.Models.User_Information", "UserInformation")
                        .WithMany("Project")
                        .HasForeignKey("User_Id")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("UserInformation");

                    b.Navigation("UserInformation1");

                    b.Navigation("UserInformation2");
                });

            modelBuilder.Entity("MiniProject_LinkedIn.Models.Skill", b =>
                {
                    b.HasOne("MiniProject_LinkedIn.Models.User_Information", "UserInformation1")
                        .WithMany("skills1")
                        .HasForeignKey("CreatedById")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("MiniProject_LinkedIn.Models.User_Information", "UserInformation2")
                        .WithMany("skills2")
                        .HasForeignKey("ModifiedById")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("MiniProject_LinkedIn.Models.User_Information", "UserInformation")
                        .WithMany("skills")
                        .HasForeignKey("User_Id")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("UserInformation");

                    b.Navigation("UserInformation1");

                    b.Navigation("UserInformation2");
                });

            modelBuilder.Entity("MiniProject_LinkedIn.Models.UserConnections", b =>
                {
                    b.HasOne("MiniProject_LinkedIn.Models.User_Information", "UserInformation2")
                        .WithMany("UserConnections2")
                        .HasForeignKey("ConnectedUser_ID")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("MiniProject_LinkedIn.Models.User_Information", "UserInformation3")
                        .WithMany("UserConnections3")
                        .HasForeignKey("CreatedById")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("MiniProject_LinkedIn.Models.User_Information", "UserInformation4")
                        .WithMany("UserConnections4")
                        .HasForeignKey("ModifiedById")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("MiniProject_LinkedIn.Models.User_Information", "UserInformation1")
                        .WithMany("UserConnections1")
                        .HasForeignKey("User_ID")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("UserInformation1");

                    b.Navigation("UserInformation2");

                    b.Navigation("UserInformation3");

                    b.Navigation("UserInformation4");
                });

            modelBuilder.Entity("MiniProject_LinkedIn.Models.User_Information", b =>
                {
                    b.HasOne("MiniProject_LinkedIn.Models.User_Information", "UserInformation1")
                        .WithOne()
                        .HasForeignKey("MiniProject_LinkedIn.Models.User_Information", "CreatedById")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("MiniProject_LinkedIn.Models.User_Information", "UserInformation2")
                        .WithOne()
                        .HasForeignKey("MiniProject_LinkedIn.Models.User_Information", "ModifiedById")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("UserInformation1");

                    b.Navigation("UserInformation2");
                });

            modelBuilder.Entity("MiniProject_LinkedIn.Models.User_Post", b =>
                {
                    b.HasOne("MiniProject_LinkedIn.Models.User_Information", "UserInformation1")
                        .WithMany("user_Posts1")
                        .HasForeignKey("CreatedById")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("MiniProject_LinkedIn.Models.User_Information", "UserInformation2")
                        .WithMany("user_Posts2")
                        .HasForeignKey("ModifiedById")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("MiniProject_LinkedIn.Models.User_Information", "UserInformation")
                        .WithMany("user_Posts")
                        .HasForeignKey("User_Id")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("UserInformation");

                    b.Navigation("UserInformation1");

                    b.Navigation("UserInformation2");
                });

            modelBuilder.Entity("MiniProject_LinkedIn.Models.Company", b =>
                {
                    b.Navigation("Experience");
                });

            modelBuilder.Entity("MiniProject_LinkedIn.Models.ObjectType", b =>
                {
                    b.Navigation("Objects");

                    b.Navigation("ParentObject");
                });

            modelBuilder.Entity("MiniProject_LinkedIn.Models.PostComments", b =>
                {
                    b.Navigation("CommentLikes");
                });

            modelBuilder.Entity("MiniProject_LinkedIn.Models.User_Information", b =>
                {
                    b.Navigation("LicansesCertificate1");

                    b.Navigation("LicansesCertificate2");

                    b.Navigation("LicansesCertificate3");

                    b.Navigation("PostComments");

                    b.Navigation("PostComments1");

                    b.Navigation("PostComments2");

                    b.Navigation("Project");

                    b.Navigation("Project1");

                    b.Navigation("Project2");

                    b.Navigation("UserConnections1");

                    b.Navigation("UserConnections2");

                    b.Navigation("UserConnections3");

                    b.Navigation("UserConnections4");

                    b.Navigation("commentLikes");

                    b.Navigation("commentLikes1");

                    b.Navigation("commentLikes2");

                    b.Navigation("experiences");

                    b.Navigation("experiences1");

                    b.Navigation("experiences2");

                    b.Navigation("postLikes");

                    b.Navigation("postLikes1");

                    b.Navigation("postLikes2");

                    b.Navigation("skills");

                    b.Navigation("skills1");

                    b.Navigation("skills2");

                    b.Navigation("user_Posts");

                    b.Navigation("user_Posts1");

                    b.Navigation("user_Posts2");
                });

            modelBuilder.Entity("MiniProject_LinkedIn.Models.User_Post", b =>
                {
                    b.Navigation("PostComments");

                    b.Navigation("PostLikes");
                });
#pragma warning restore 612, 618
        }
    }
}