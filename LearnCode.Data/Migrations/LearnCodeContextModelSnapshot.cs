﻿// <auto-generated />
using System;
using LearnCode.Data.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LearnCode.Data.Migrations
{
    [DbContext(typeof(LearnCodeContext))]
    partial class LearnCodeContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("learncode")
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("LearnCode.Domain.ProgrammingLanguages.PLItem", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("EducatorId");

                    b.Property<string>("Image");

                    b.Property<string>("LearnCodeUserId");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("EducatorId");

                    b.HasIndex("LearnCodeUserId");

                    b.ToTable("ProgrammingLanguages");
                });

            modelBuilder.Entity("LearnCode.Domain.Tutorials.AuthorItem", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Intro");

                    b.Property<string>("Name");

                    b.Property<Guid>("TutorialId");

                    b.HasKey("Id");

                    b.ToTable("AuthorItem");
                });

            modelBuilder.Entity("LearnCode.Domain.Tutorials.Criticism", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid?>("AuthorId");

                    b.Property<string>("Body");

                    b.Property<Guid?>("EducatorId");

                    b.Property<string>("EducatorId1");

                    b.Property<double>("Rating");

                    b.Property<Guid?>("TutorialId");

                    b.Property<Guid?>("TutorialItemId");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.HasIndex("EducatorId1");

                    b.HasIndex("TutorialItemId");

                    b.ToTable("Criticism");
                });

            modelBuilder.Entity("LearnCode.Domain.Tutorials.TagItem", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Title");

                    b.Property<Guid>("TutorialId");

                    b.Property<Guid?>("TutorialItemId");

                    b.HasKey("Id");

                    b.HasIndex("TutorialItemId");

                    b.ToTable("TagItem");
                });

            modelBuilder.Entity("LearnCode.Domain.Tutorials.TutorialItem", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid?>("AuthorId");

                    b.Property<DateTime>("DateCreated");

                    b.Property<DateTime>("DateUpdated");

                    b.Property<string>("EducatorId");

                    b.Property<string>("Image");

                    b.Property<string>("SkillLevel");

                    b.Property<string>("Subject");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.HasIndex("EducatorId");

                    b.HasIndex("Title")
                        .IsUnique();

                    b.ToTable("Tutorials");
                });

            modelBuilder.Entity("LearnCode.Domain.Users.EducationItem", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Education");

                    b.Property<string>("Institution");

                    b.Property<Guid>("UserId");

                    b.Property<int?>("YearOfGraduation");

                    b.HasKey("Id");

                    b.ToTable("EducationItem");
                });

            modelBuilder.Entity("LearnCode.Domain.Users.FavoriteTutorial", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Link");

                    b.Property<string>("StudentId");

                    b.Property<string>("Subject");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.HasIndex("StudentId");

                    b.ToTable("FavoriteTutorial");
                });

            modelBuilder.Entity("LearnCode.Domain.Users.Fee", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("Amount");

                    b.Property<string>("Description");

                    b.Property<Guid?>("StripePaymentId");

                    b.Property<string>("Type");

                    b.Property<Guid>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("StripePaymentId");

                    b.ToTable("Fee");
                });

            modelBuilder.Entity("LearnCode.Domain.Users.LearnCodeUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("Avatar");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<string>("DisplayName");

                    b.Property<Guid?>("EducationId");

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("Intro");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("Name");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("Occupation");

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<int>("ProgrammingExperience");

                    b.Property<string>("PushNotificationToken");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("EducationId");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex");

                    b.ToTable("AspNetUsers");

                    b.HasDiscriminator<string>("Discriminator").HasValue("LearnCodeUser");
                });

            modelBuilder.Entity("LearnCode.Domain.Users.StripePayment", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AddressCity");

                    b.Property<string>("AddressCountry");

                    b.Property<string>("AddressLine1");

                    b.Property<string>("AddressLine2");

                    b.Property<string>("AddressPostCode");

                    b.Property<double>("Amount");

                    b.Property<string>("CardHolderName");

                    b.Property<string>("EducatorId");

                    b.Property<string>("StudentId");

                    b.Property<string>("Token");

                    b.HasKey("Id");

                    b.HasIndex("EducatorId");

                    b.HasIndex("StudentId");

                    b.ToTable("StripePayment");
                });

            modelBuilder.Entity("LearnCode.Domain.Users.SubscriptionStatus", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("Price");

                    b.Property<string>("Subscription");

                    b.HasKey("Id");

                    b.ToTable("SubscriptionStatus");
                });

            modelBuilder.Entity("LearnCode.Domain.Users.TrophyItem", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AmountOfGoodReviews");

                    b.Property<string>("Trophy");

                    b.HasKey("Id");

                    b.ToTable("TrophyItem");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("LearnCode.Domain.Users.Educator", b =>
                {
                    b.HasBaseType("LearnCode.Domain.Users.LearnCodeUser");

                    b.Property<Guid?>("TrophyId");

                    b.HasIndex("TrophyId");

                    b.ToTable("Educator");

                    b.HasDiscriminator().HasValue("Educator");
                });

            modelBuilder.Entity("LearnCode.Domain.Users.Student", b =>
                {
                    b.HasBaseType("LearnCode.Domain.Users.LearnCodeUser");

                    b.Property<Guid?>("SubscriptionStatusId");

                    b.HasIndex("SubscriptionStatusId");

                    b.ToTable("Student");

                    b.HasDiscriminator().HasValue("Student");
                });

            modelBuilder.Entity("LearnCode.Domain.ProgrammingLanguages.PLItem", b =>
                {
                    b.HasOne("LearnCode.Domain.Users.Educator")
                        .WithMany("LanguageOfExpertise")
                        .HasForeignKey("EducatorId");

                    b.HasOne("LearnCode.Domain.Users.LearnCodeUser")
                        .WithMany("FavoriteProgammingLanguages")
                        .HasForeignKey("LearnCodeUserId");
                });

            modelBuilder.Entity("LearnCode.Domain.Tutorials.Criticism", b =>
                {
                    b.HasOne("LearnCode.Domain.Tutorials.AuthorItem", "Author")
                        .WithMany()
                        .HasForeignKey("AuthorId");

                    b.HasOne("LearnCode.Domain.Users.Educator")
                        .WithMany("Reviews")
                        .HasForeignKey("EducatorId1");

                    b.HasOne("LearnCode.Domain.Tutorials.TutorialItem")
                        .WithMany("Criticisms")
                        .HasForeignKey("TutorialItemId");
                });

            modelBuilder.Entity("LearnCode.Domain.Tutorials.TagItem", b =>
                {
                    b.HasOne("LearnCode.Domain.Tutorials.TutorialItem")
                        .WithMany("Tags")
                        .HasForeignKey("TutorialItemId");
                });

            modelBuilder.Entity("LearnCode.Domain.Tutorials.TutorialItem", b =>
                {
                    b.HasOne("LearnCode.Domain.Tutorials.AuthorItem", "Author")
                        .WithMany()
                        .HasForeignKey("AuthorId");

                    b.HasOne("LearnCode.Domain.Users.Educator")
                        .WithMany("Tutorials")
                        .HasForeignKey("EducatorId");
                });

            modelBuilder.Entity("LearnCode.Domain.Users.FavoriteTutorial", b =>
                {
                    b.HasOne("LearnCode.Domain.Users.Student")
                        .WithMany("FavoriteTutorials")
                        .HasForeignKey("StudentId");
                });

            modelBuilder.Entity("LearnCode.Domain.Users.Fee", b =>
                {
                    b.HasOne("LearnCode.Domain.Users.StripePayment")
                        .WithMany("Fees")
                        .HasForeignKey("StripePaymentId");
                });

            modelBuilder.Entity("LearnCode.Domain.Users.LearnCodeUser", b =>
                {
                    b.HasOne("LearnCode.Domain.Users.EducationItem", "Education")
                        .WithMany()
                        .HasForeignKey("EducationId");
                });

            modelBuilder.Entity("LearnCode.Domain.Users.StripePayment", b =>
                {
                    b.HasOne("LearnCode.Domain.Users.Educator")
                        .WithMany("BillingHistory")
                        .HasForeignKey("EducatorId");

                    b.HasOne("LearnCode.Domain.Users.Student")
                        .WithMany("Charges")
                        .HasForeignKey("StudentId");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("LearnCode.Domain.Users.LearnCodeUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("LearnCode.Domain.Users.LearnCodeUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("LearnCode.Domain.Users.LearnCodeUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("LearnCode.Domain.Users.LearnCodeUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("LearnCode.Domain.Users.Educator", b =>
                {
                    b.HasOne("LearnCode.Domain.Users.TrophyItem", "Trophy")
                        .WithMany()
                        .HasForeignKey("TrophyId");
                });

            modelBuilder.Entity("LearnCode.Domain.Users.Student", b =>
                {
                    b.HasOne("LearnCode.Domain.Users.SubscriptionStatus", "SubscriptionStatus")
                        .WithMany()
                        .HasForeignKey("SubscriptionStatusId");
                });
#pragma warning restore 612, 618
        }
    }
}
