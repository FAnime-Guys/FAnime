﻿// <auto-generated />
using System;
using Fanime.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Fanime.Persistence.Migrations
{
    [DbContext(typeof(FanimeDbContext))]
    partial class FanimeDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Fanime.Domain.Entities.Author", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("int");

                    b.Property<string>("Firstname")
                        .IsRequired()
                        .HasColumnName("firstname")
                        .HasColumnType("varchar(150)")
                        .HasMaxLength(150);

                    b.Property<string>("Lastname")
                        .IsRequired()
                        .HasColumnName("lastname")
                        .HasColumnType("varchar(150)")
                        .HasMaxLength(150);

                    b.HasKey("Id");

                    b.ToTable("authors");
                });

            modelBuilder.Entity("Fanime.Domain.Entities.AuthorDetail", b =>
                {
                    b.Property<int>("AuthorId")
                        .HasColumnName("author_id")
                        .HasColumnType("int");

                    b.Property<int>("MangaId")
                        .HasColumnName("manga_id")
                        .HasColumnType("int");

                    b.HasKey("AuthorId", "MangaId");

                    b.HasIndex("MangaId");

                    b.ToTable("author_details");
                });

            modelBuilder.Entity("Fanime.Domain.Entities.Chapter", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("int");

                    b.Property<int>("MangaId")
                        .HasColumnName("manga_id")
                        .HasColumnType("int");

                    b.Property<string>("Summary")
                        .HasColumnName("summary")
                        .HasColumnType("text");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnName("title")
                        .HasColumnType("varchar(250)")
                        .HasMaxLength(250);

                    b.HasKey("Id");

                    b.HasIndex("MangaId");

                    b.ToTable("chapters");
                });

            modelBuilder.Entity("Fanime.Domain.Entities.Character", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("int");

                    b.Property<string>("Firstname")
                        .IsRequired()
                        .HasColumnName("firstname")
                        .HasColumnType("varchar(250)")
                        .HasMaxLength(250);

                    b.Property<string>("Lastname")
                        .IsRequired()
                        .HasColumnName("lastname")
                        .HasColumnType("varchar(250)")
                        .HasMaxLength(250);

                    b.HasKey("Id");

                    b.ToTable("characters");
                });

            modelBuilder.Entity("Fanime.Domain.Entities.CollectionBase", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("int");

                    b.Property<string>("collection_type")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("collections");

                    b.HasDiscriminator<string>("collection_type").HasValue("CollectionBase");
                });

            modelBuilder.Entity("Fanime.Domain.Entities.CollectionCharacter", b =>
                {
                    b.Property<int>("CharacterId")
                        .HasColumnName("character_id")
                        .HasColumnType("int");

                    b.Property<int>("CollectionId")
                        .HasColumnName("collection_id")
                        .HasColumnType("int");

                    b.HasKey("CharacterId", "CollectionId");

                    b.HasIndex("CollectionId");

                    b.ToTable("collection_characters");
                });

            modelBuilder.Entity("Fanime.Domain.Entities.CollectionItem", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnName("id")
                        .HasColumnType("int");

                    b.Property<int>("CollectionId")
                        .HasColumnName("collection_id")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnName("user_id")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnName("status")
                        .HasColumnType("varchar(20)");

                    b.HasKey("Id", "CollectionId", "UserId");

                    b.HasIndex("CollectionId");

                    b.HasIndex("UserId");

                    b.ToTable("collection_items");
                });

            modelBuilder.Entity("Fanime.Domain.Entities.Episode", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("int");

                    b.Property<DateTime>("AirDate")
                        .HasColumnName("air_date")
                        .HasColumnType("datetime");

                    b.Property<int>("AnimeId")
                        .HasColumnName("anime_id")
                        .HasColumnType("int");

                    b.Property<string>("Summary")
                        .HasColumnName("summary")
                        .HasColumnType("text");

                    b.Property<string>("Title")
                        .HasColumnName("title")
                        .HasColumnType("varchar(150)")
                        .HasMaxLength(150);

                    b.HasKey("Id");

                    b.HasIndex("AnimeId");

                    b.ToTable("episodes");
                });

            modelBuilder.Entity("Fanime.Domain.Entities.Producer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("name")
                        .HasColumnType("varchar(150)")
                        .HasMaxLength(150);

                    b.HasKey("Id");

                    b.ToTable("producers");
                });

            modelBuilder.Entity("Fanime.Domain.Entities.ProducerStudioDetail", b =>
                {
                    b.Property<int>("AnimeId")
                        .HasColumnName("anime_id")
                        .HasColumnType("int");

                    b.Property<int>("ProducerId")
                        .HasColumnName("producer_id")
                        .HasColumnType("int");

                    b.Property<int>("StudioId")
                        .HasColumnName("studio_id")
                        .HasColumnType("int");

                    b.HasKey("AnimeId", "ProducerId", "StudioId");

                    b.HasIndex("ProducerId");

                    b.HasIndex("StudioId");

                    b.ToTable("producer_studio_details");
                });

            modelBuilder.Entity("Fanime.Domain.Entities.Review", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnName("description")
                        .HasColumnType("text");

                    b.Property<int>("EntityId")
                        .HasColumnName("collection_id")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnName("user_id")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EntityId");

                    b.HasIndex("UserId");

                    b.ToTable("reviews");
                });

            modelBuilder.Entity("Fanime.Domain.Entities.Studio", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("name")
                        .HasColumnType("varchar(150)")
                        .HasMaxLength(150);

                    b.HasKey("Id");

                    b.ToTable("studios");
                });

            modelBuilder.Entity("Fanime.Domain.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("int");

                    b.Property<string>("Biography")
                        .HasColumnName("biography")
                        .HasColumnType("text");

                    b.Property<DateTime>("Created")
                        .HasColumnName("created")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("DateOfBirth")
                        .HasColumnName("date_of_birth")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("Deactivated")
                        .HasColumnName("deactivated")
                        .HasColumnType("datetime");

                    b.Property<string>("DisplayName")
                        .IsRequired()
                        .HasColumnName("display_name")
                        .HasColumnType("varchar(150)")
                        .HasMaxLength(150);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnName("email")
                        .HasColumnType("text");

                    b.Property<DateTime?>("EmailConfirmed")
                        .HasColumnName("email_confirmed")
                        .HasColumnType("datetime");

                    b.Property<string>("Gender")
                        .HasColumnName("gender")
                        .HasColumnType("text");

                    b.Property<string>("Image")
                        .HasColumnName("image")
                        .HasColumnType("text");

                    b.Property<string>("Location")
                        .HasColumnName("location")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("users");
                });

            modelBuilder.Entity("Fanime.Domain.Entities.UserFriend", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnName("user_id")
                        .HasColumnType("int");

                    b.Property<int>("FriendId")
                        .HasColumnName("friend_id")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .HasColumnName("status")
                        .HasColumnType("varchar(20)");

                    b.Property<DateTime?>("Accepted")
                        .HasColumnName("accepted")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("Blocked")
                        .HasColumnName("blocked")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("Invited")
                        .HasColumnName("invited")
                        .HasColumnType("datetime");

                    b.Property<int?>("UserId1")
                        .HasColumnType("int");

                    b.HasKey("UserId", "FriendId", "Status");

                    b.HasIndex("FriendId");

                    b.HasIndex("UserId1");

                    b.ToTable("user_friends");
                });

            modelBuilder.Entity("Fanime.Domain.Entities.VoiceActor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("int");

                    b.Property<string>("Firstname")
                        .IsRequired()
                        .HasColumnName("firstname")
                        .HasColumnType("varchar(150)")
                        .HasMaxLength(150);

                    b.Property<string>("Lastname")
                        .IsRequired()
                        .HasColumnName("lastname")
                        .HasColumnType("varchar(150)")
                        .HasMaxLength(150);

                    b.HasKey("Id");

                    b.ToTable("voice_actors");
                });

            modelBuilder.Entity("Fanime.Domain.Entities.VoiceActorDetail", b =>
                {
                    b.Property<int>("VoiceActorId")
                        .HasColumnName("voice_actor_id")
                        .HasColumnType("int");

                    b.Property<int>("CharacterId")
                        .HasColumnName("character_id")
                        .HasColumnType("int");

                    b.HasKey("VoiceActorId", "CharacterId");

                    b.HasIndex("CharacterId");

                    b.ToTable("voice_actor_details");
                });

            modelBuilder.Entity("Fanime.Domain.Entities.Anime", b =>
                {
                    b.HasBaseType("Fanime.Domain.Entities.CollectionBase");

                    b.Property<DateTime?>("EndDate")
                        .HasColumnName("end_date")
                        .HasColumnType("datetime");

                    b.Property<string>("Kanji")
                        .IsRequired()
                        .HasColumnName("kanji")
                        .HasColumnType("varchar(250)")
                        .HasMaxLength(250);

                    b.Property<string>("Romanji")
                        .IsRequired()
                        .HasColumnName("romanji")
                        .HasColumnType("varchar(250)")
                        .HasMaxLength(250);

                    b.Property<DateTime?>("StartDate")
                        .HasColumnName("start_date")
                        .HasColumnType("datetime");

                    b.Property<string>("Summary")
                        .HasColumnName("summary")
                        .HasColumnType("text");

                    b.Property<string>("Synonyms")
                        .HasColumnName("synonyms")
                        .HasColumnType("text");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnName("title")
                        .HasColumnType("varchar(250)")
                        .HasMaxLength(250);

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnName("anime_type")
                        .HasColumnType("varchar(10)");

                    b.HasDiscriminator().HasValue("anime");
                });

            modelBuilder.Entity("Fanime.Domain.Entities.Manga", b =>
                {
                    b.HasBaseType("Fanime.Domain.Entities.CollectionBase");

                    b.Property<string>("Kanji")
                        .IsRequired()
                        .HasColumnName("kanji")
                        .HasColumnType("varchar(250)")
                        .HasMaxLength(250);

                    b.Property<string>("Romanji")
                        .IsRequired()
                        .HasColumnName("romanji")
                        .HasColumnType("varchar(250)")
                        .HasMaxLength(250);

                    b.Property<string>("Synonyms")
                        .HasColumnName("synonyms")
                        .HasColumnType("text");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnName("title")
                        .HasColumnType("varchar(250)")
                        .HasMaxLength(250);

                    b.HasDiscriminator().HasValue("manga");
                });

            modelBuilder.Entity("Fanime.Domain.Entities.AuthorDetail", b =>
                {
                    b.HasOne("Fanime.Domain.Entities.Author", "Author")
                        .WithMany("AuthorDetails")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Fanime.Domain.Entities.Manga", "Manga")
                        .WithMany("AuthorDetails")
                        .HasForeignKey("MangaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Fanime.Domain.Entities.Chapter", b =>
                {
                    b.HasOne("Fanime.Domain.Entities.Manga", "Manga")
                        .WithMany("Chapters")
                        .HasForeignKey("MangaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Fanime.Domain.Entities.CollectionCharacter", b =>
                {
                    b.HasOne("Fanime.Domain.Entities.Character", "Character")
                        .WithMany("CollectionCharacters")
                        .HasForeignKey("CharacterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Fanime.Domain.Entities.CollectionBase", "Collection")
                        .WithMany("CollectionCharacters")
                        .HasForeignKey("CollectionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Fanime.Domain.Entities.CollectionItem", b =>
                {
                    b.HasOne("Fanime.Domain.Entities.CollectionBase", "Collection")
                        .WithMany("Collections")
                        .HasForeignKey("CollectionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Fanime.Domain.Entities.User", "User")
                        .WithMany("Collections")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Fanime.Domain.Entities.Episode", b =>
                {
                    b.HasOne("Fanime.Domain.Entities.Anime", "Anime")
                        .WithMany("Episodes")
                        .HasForeignKey("AnimeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Fanime.Domain.Entities.ProducerStudioDetail", b =>
                {
                    b.HasOne("Fanime.Domain.Entities.Anime", "Anime")
                        .WithMany("ProducerStudioDetails")
                        .HasForeignKey("AnimeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Fanime.Domain.Entities.Producer", "Producer")
                        .WithMany("ProducerStudioDetails")
                        .HasForeignKey("ProducerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Fanime.Domain.Entities.Studio", "Studio")
                        .WithMany("ProducerStudioDetails")
                        .HasForeignKey("StudioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Fanime.Domain.Entities.Review", b =>
                {
                    b.HasOne("Fanime.Domain.Entities.CollectionBase", "Entity")
                        .WithMany("Reviews")
                        .HasForeignKey("EntityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Fanime.Domain.Entities.User", "User")
                        .WithMany("Reviews")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Fanime.Domain.Entities.UserFriend", b =>
                {
                    b.HasOne("Fanime.Domain.Entities.User", "Friend")
                        .WithMany()
                        .HasForeignKey("FriendId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Fanime.Domain.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Fanime.Domain.Entities.User", null)
                        .WithMany("Friends")
                        .HasForeignKey("UserId1");
                });

            modelBuilder.Entity("Fanime.Domain.Entities.VoiceActorDetail", b =>
                {
                    b.HasOne("Fanime.Domain.Entities.Character", "Character")
                        .WithMany("VoiceActorDetails")
                        .HasForeignKey("CharacterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Fanime.Domain.Entities.VoiceActor", "VoiceActor")
                        .WithMany("VoiceActorDetails")
                        .HasForeignKey("VoiceActorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
