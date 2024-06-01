﻿// <auto-generated />
using System;
using IMS.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Model.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240531155145_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("IMS.Models.Entities.Account", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("NEWID()");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DOB")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("DeletedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("DeletionDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<Guid?>("ModifiedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("Accounts");
                });

            modelBuilder.Entity("IMS.Models.Entities.Assignment", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("DeletedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("DeletionDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Enđate")
                        .HasColumnType("datetime2");

                    b.Property<bool?>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<Guid?>("ModifiedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Assignments");
                });

            modelBuilder.Entity("IMS.Models.Entities.Campaign", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("DeletedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("DeletionDate")
                        .HasColumnType("datetime2");

                    b.Property<bool?>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<Guid?>("ModifiedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Campaigns");
                });

            modelBuilder.Entity("IMS.Models.Entities.Document", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("DeletedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("DeletionDate")
                        .HasColumnType("datetime2");

                    b.Property<bool?>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<Guid?>("LessonId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Link")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("ModifiedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("LessonId");

                    b.ToTable("Documents");
                });

            modelBuilder.Entity("IMS.Models.Entities.EmailSend", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("DeletedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("DeletionDate")
                        .HasColumnType("datetime2");

                    b.Property<bool?>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<Guid?>("ModifiedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("SendDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("SenderId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("TemplateId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("SenderId");

                    b.HasIndex("TemplateId");

                    b.ToTable("EmailSends");
                });

            modelBuilder.Entity("IMS.Models.Entities.EmailSendTrainee", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("EmailSendId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("ReceiveId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("EmailSendId");

                    b.HasIndex("ReceiveId");

                    b.ToTable("EmailSendTrainees");
                });

            modelBuilder.Entity("IMS.Models.Entities.EmailTemplate", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("DeletedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("DeletionDate")
                        .HasColumnType("datetime2");

                    b.Property<bool?>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<Guid?>("ModifiedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("EmailTemplates");
                });

            modelBuilder.Entity("IMS.Models.Entities.Lesson", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("CampaignId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("DeletedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("DeletionDate")
                        .HasColumnType("datetime2");

                    b.Property<bool?>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<Guid?>("ModifiedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CampaignId");

                    b.ToTable("Lessons");
                });

            modelBuilder.Entity("IMS.Models.Entities.ProgramCampaign", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("CampaignId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("ProgramId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("CampaignId");

                    b.HasIndex("ProgramId");

                    b.ToTable("ProgramCampaigns");
                });

            modelBuilder.Entity("IMS.Models.Entities.Role", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("IMS.Models.Entities.Score", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<float?>("Asm1")
                        .HasColumnType("real");

                    b.Property<float?>("Asm2")
                        .HasColumnType("real");

                    b.Property<float?>("Asm3")
                        .HasColumnType("real");

                    b.Property<float?>("Asm4")
                        .HasColumnType("real");

                    b.Property<float?>("Asm5")
                        .HasColumnType("real");

                    b.Property<float?>("AsmAvg")
                        .HasColumnType("real");

                    b.Property<float?>("Audit")
                        .HasColumnType("real");

                    b.Property<Guid?>("CreatedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("DeletedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("DeletionDate")
                        .HasColumnType("datetime2");

                    b.Property<float?>("GPAModule")
                        .HasColumnType("real");

                    b.Property<bool?>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("LevelModule")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("ModifiedBy")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<float?>("PraticeFinal")
                        .HasColumnType("real");

                    b.Property<float?>("Quiz1")
                        .HasColumnType("real");

                    b.Property<float?>("Quiz2")
                        .HasColumnType("real");

                    b.Property<float?>("Quiz3")
                        .HasColumnType("real");

                    b.Property<float?>("Quiz4")
                        .HasColumnType("real");

                    b.Property<float?>("Quiz5")
                        .HasColumnType("real");

                    b.Property<float?>("Quiz6")
                        .HasColumnType("real");

                    b.Property<float?>("QuizAvg")
                        .HasColumnType("real");

                    b.Property<float?>("QuizFinal")
                        .HasColumnType("real");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("TraineeId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("TraineeId");

                    b.ToTable("Scores");
                });

            modelBuilder.Entity("IMS.Models.Entities.Trainee", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DOB")
                        .HasColumnType("datetime2");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("ProgramId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("University")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ProgramId");

                    b.ToTable("Trainees");
                });

            modelBuilder.Entity("IMS.Models.Entities.TrainingProgram", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("AccountId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("AssignmentId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Duration")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AccountId");

                    b.HasIndex("AssignmentId");

                    b.ToTable("TrainingPrograms");
                });

            modelBuilder.Entity("IMS.Models.Entities.Account", b =>
                {
                    b.HasOne("IMS.Models.Entities.Role", "Role")
                        .WithMany("Accounts")
                        .HasForeignKey("RoleId");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("IMS.Models.Entities.Document", b =>
                {
                    b.HasOne("IMS.Models.Entities.Lesson", "Lesson")
                        .WithMany("Documents")
                        .HasForeignKey("LessonId");

                    b.Navigation("Lesson");
                });

            modelBuilder.Entity("IMS.Models.Entities.EmailSend", b =>
                {
                    b.HasOne("IMS.Models.Entities.Account", "Account")
                        .WithMany("EmailSends")
                        .HasForeignKey("SenderId");

                    b.HasOne("IMS.Models.Entities.EmailTemplate", "EmailTemplate")
                        .WithMany("EmailSends")
                        .HasForeignKey("TemplateId");

                    b.Navigation("Account");

                    b.Navigation("EmailTemplate");
                });

            modelBuilder.Entity("IMS.Models.Entities.EmailSendTrainee", b =>
                {
                    b.HasOne("IMS.Models.Entities.EmailSend", "EmailSend")
                        .WithMany("EmailSendTrainee")
                        .HasForeignKey("EmailSendId");

                    b.HasOne("IMS.Models.Entities.Trainee", "Trainee")
                        .WithMany("EmailSendTrainees")
                        .HasForeignKey("ReceiveId");

                    b.Navigation("EmailSend");

                    b.Navigation("Trainee");
                });

            modelBuilder.Entity("IMS.Models.Entities.Lesson", b =>
                {
                    b.HasOne("IMS.Models.Entities.Campaign", "Campaign")
                        .WithMany("Lessons")
                        .HasForeignKey("CampaignId");

                    b.Navigation("Campaign");
                });

            modelBuilder.Entity("IMS.Models.Entities.ProgramCampaign", b =>
                {
                    b.HasOne("IMS.Models.Entities.Campaign", "Campaign")
                        .WithMany("ProgramCampaigns")
                        .HasForeignKey("CampaignId");

                    b.HasOne("IMS.Models.Entities.TrainingProgram", "TrainingProgram")
                        .WithMany("ProgramCampaigns")
                        .HasForeignKey("ProgramId");

                    b.Navigation("Campaign");

                    b.Navigation("TrainingProgram");
                });

            modelBuilder.Entity("IMS.Models.Entities.Score", b =>
                {
                    b.HasOne("IMS.Models.Entities.Trainee", "Trainee")
                        .WithMany("Scores")
                        .HasForeignKey("TraineeId");

                    b.Navigation("Trainee");
                });

            modelBuilder.Entity("IMS.Models.Entities.Trainee", b =>
                {
                    b.HasOne("IMS.Models.Entities.TrainingProgram", "TrainingProgram")
                        .WithMany("Trainees")
                        .HasForeignKey("ProgramId");

                    b.Navigation("TrainingProgram");
                });

            modelBuilder.Entity("IMS.Models.Entities.TrainingProgram", b =>
                {
                    b.HasOne("IMS.Models.Entities.Account", "Account")
                        .WithMany("TrainingPrograms")
                        .HasForeignKey("AccountId");

                    b.HasOne("IMS.Models.Entities.Assignment", "Assignment")
                        .WithMany("TrainingPrograms")
                        .HasForeignKey("AssignmentId");

                    b.Navigation("Account");

                    b.Navigation("Assignment");
                });

            modelBuilder.Entity("IMS.Models.Entities.Account", b =>
                {
                    b.Navigation("EmailSends");

                    b.Navigation("TrainingPrograms");
                });

            modelBuilder.Entity("IMS.Models.Entities.Assignment", b =>
                {
                    b.Navigation("TrainingPrograms");
                });

            modelBuilder.Entity("IMS.Models.Entities.Campaign", b =>
                {
                    b.Navigation("Lessons");

                    b.Navigation("ProgramCampaigns");
                });

            modelBuilder.Entity("IMS.Models.Entities.EmailSend", b =>
                {
                    b.Navigation("EmailSendTrainee");
                });

            modelBuilder.Entity("IMS.Models.Entities.EmailTemplate", b =>
                {
                    b.Navigation("EmailSends");
                });

            modelBuilder.Entity("IMS.Models.Entities.Lesson", b =>
                {
                    b.Navigation("Documents");
                });

            modelBuilder.Entity("IMS.Models.Entities.Role", b =>
                {
                    b.Navigation("Accounts");
                });

            modelBuilder.Entity("IMS.Models.Entities.Trainee", b =>
                {
                    b.Navigation("EmailSendTrainees");

                    b.Navigation("Scores");
                });

            modelBuilder.Entity("IMS.Models.Entities.TrainingProgram", b =>
                {
                    b.Navigation("ProgramCampaigns");

                    b.Navigation("Trainees");
                });
#pragma warning restore 612, 618
        }
    }
}
