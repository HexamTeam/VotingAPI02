﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VotingAPI.DataAccess;

namespace VotingAPI.DataAccess.Migrations
{
    [DbContext(typeof(VotingDbContext))]
    [Migration("20211122141335_TPtoParty")]
    partial class TPtoParty
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("VotingAPI.Models.Admin", b =>
                {
                    b.Property<string>("AdminID")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EDID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ElectionDPEDID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NIC")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AdminID");

                    b.HasIndex("ElectionDPEDID");

                    b.ToTable("Admins");
                });

            modelBuilder.Entity("VotingAPI.Models.Candidate", b =>
                {
                    b.Property<string>("CID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<string>("NIC")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PartyName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PartyName1")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ResultDID")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("CID");

                    b.HasIndex("PartyName1");

                    b.HasIndex("ResultDID");

                    b.ToTable("Candidates");
                });

            modelBuilder.Entity("VotingAPI.Models.ElectionDP", b =>
                {
                    b.Property<string>("EDID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Telephone")
                        .HasColumnType("int");

                    b.HasKey("EDID");

                    b.ToTable("ElectionDPs");
                });

            modelBuilder.Entity("VotingAPI.Models.GramaNiladhari", b =>
                {
                    b.Property<string>("GNID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("AdminID")
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("DSDivision")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("GNDivision")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GNID");

                    b.HasIndex("AdminID");

                    b.ToTable("GramaNiladharis");
                });

            modelBuilder.Entity("VotingAPI.Models.Party", b =>
                {
                    b.Property<string>("PartyName")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AdminID")
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("TelphoneNo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PartyName");

                    b.HasIndex("AdminID");

                    b.ToTable("Parties");
                });

            modelBuilder.Entity("VotingAPI.Models.Result", b =>
                {
                    b.Property<string>("DID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Count")
                        .HasColumnType("int");

                    b.Property<string>("District")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EDID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ElectionDPEDID")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("DID");

                    b.HasIndex("ElectionDPEDID");

                    b.ToTable("Results");
                });

            modelBuilder.Entity("VotingAPI.Models.Voter", b =>
                {
                    b.Property<string>("VNIC")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GNID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<string>("GramaNiladhariGNID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("MaritalStatus")
                        .HasColumnType("int");

                    b.Property<int>("MyProperty")
                        .HasColumnType("int");

                    b.Property<string>("Occupation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostalCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Vote")
                        .HasColumnType("bit");

                    b.HasKey("VNIC");

                    b.HasIndex("GramaNiladhariGNID");

                    b.ToTable("Voters");
                });

            modelBuilder.Entity("VotingAPI.Models.Voter_Candidate", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CandidateCID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("VNIC")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VoterVNIC")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("ID");

                    b.HasIndex("CandidateCID");

                    b.HasIndex("VoterVNIC");

                    b.ToTable("Voter_Candidates");
                });

            modelBuilder.Entity("VotingAPI.Models.Admin", b =>
                {
                    b.HasOne("VotingAPI.Models.ElectionDP", "ElectionDP")
                        .WithMany("admins")
                        .HasForeignKey("ElectionDPEDID");

                    b.Navigation("ElectionDP");
                });

            modelBuilder.Entity("VotingAPI.Models.Candidate", b =>
                {
                    b.HasOne("VotingAPI.Models.Party", "Party")
                        .WithMany("candidates")
                        .HasForeignKey("PartyName1");

                    b.HasOne("VotingAPI.Models.Result", "Result")
                        .WithMany("candidates")
                        .HasForeignKey("ResultDID");

                    b.Navigation("Party");

                    b.Navigation("Result");
                });

            modelBuilder.Entity("VotingAPI.Models.GramaNiladhari", b =>
                {
                    b.HasOne("VotingAPI.Models.Admin", "Admin")
                        .WithMany("gramaNiladharis")
                        .HasForeignKey("AdminID");

                    b.Navigation("Admin");
                });

            modelBuilder.Entity("VotingAPI.Models.Party", b =>
                {
                    b.HasOne("VotingAPI.Models.Admin", "Admin")
                        .WithMany()
                        .HasForeignKey("AdminID");

                    b.Navigation("Admin");
                });

            modelBuilder.Entity("VotingAPI.Models.Result", b =>
                {
                    b.HasOne("VotingAPI.Models.ElectionDP", "ElectionDP")
                        .WithMany("results")
                        .HasForeignKey("ElectionDPEDID");

                    b.Navigation("ElectionDP");
                });

            modelBuilder.Entity("VotingAPI.Models.Voter", b =>
                {
                    b.HasOne("VotingAPI.Models.GramaNiladhari", "GramaNiladhari")
                        .WithMany()
                        .HasForeignKey("GramaNiladhariGNID");

                    b.Navigation("GramaNiladhari");
                });

            modelBuilder.Entity("VotingAPI.Models.Voter_Candidate", b =>
                {
                    b.HasOne("VotingAPI.Models.Candidate", "Candidate")
                        .WithMany("voter_Candidates")
                        .HasForeignKey("CandidateCID");

                    b.HasOne("VotingAPI.Models.Voter", "Voter")
                        .WithMany("voter_Candidates")
                        .HasForeignKey("VoterVNIC");

                    b.Navigation("Candidate");

                    b.Navigation("Voter");
                });

            modelBuilder.Entity("VotingAPI.Models.Admin", b =>
                {
                    b.Navigation("gramaNiladharis");
                });

            modelBuilder.Entity("VotingAPI.Models.Candidate", b =>
                {
                    b.Navigation("voter_Candidates");
                });

            modelBuilder.Entity("VotingAPI.Models.ElectionDP", b =>
                {
                    b.Navigation("admins");

                    b.Navigation("results");
                });

            modelBuilder.Entity("VotingAPI.Models.Party", b =>
                {
                    b.Navigation("candidates");
                });

            modelBuilder.Entity("VotingAPI.Models.Result", b =>
                {
                    b.Navigation("candidates");
                });

            modelBuilder.Entity("VotingAPI.Models.Voter", b =>
                {
                    b.Navigation("voter_Candidates");
                });
#pragma warning restore 612, 618
        }
    }
}
