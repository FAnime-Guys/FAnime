using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.Data.EntityFrameworkCore.Metadata;

namespace Fanime.Persistence.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "authors",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    firstname = table.Column<string>(maxLength: 150, nullable: false),
                    lastname = table.Column<string>(maxLength: 150, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_authors", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "characters",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    firstname = table.Column<string>(maxLength: 250, nullable: false),
                    lastname = table.Column<string>(maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_characters", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "collections",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    collection_type = table.Column<string>(nullable: false),
                    title = table.Column<string>(maxLength: 250, nullable: true),
                    kanji = table.Column<string>(maxLength: 250, nullable: true),
                    romanji = table.Column<string>(maxLength: 250, nullable: true),
                    synonyms = table.Column<string>(nullable: true),
                    summary = table.Column<string>(nullable: true),
                    anime_type = table.Column<string>(type: "varchar(10)", nullable: true),
                    start_date = table.Column<DateTime>(nullable: true),
                    end_date = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_collections", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "producers",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(maxLength: 150, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_producers", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "studios",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(maxLength: 150, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_studios", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    image = table.Column<string>(nullable: true),
                    email = table.Column<string>(nullable: false),
                    display_name = table.Column<string>(maxLength: 150, nullable: false),
                    gender = table.Column<string>(nullable: true),
                    location = table.Column<string>(nullable: true),
                    biography = table.Column<string>(nullable: true),
                    date_of_birth = table.Column<DateTime>(nullable: true),
                    email_confirmed = table.Column<DateTime>(nullable: true),
                    created = table.Column<DateTime>(nullable: false),
                    deactivated = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "voice_actors",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    firstname = table.Column<string>(maxLength: 150, nullable: false),
                    lastname = table.Column<string>(maxLength: 150, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_voice_actors", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "author_details",
                columns: table => new
                {
                    author_id = table.Column<int>(nullable: false),
                    manga_id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_author_details", x => new { x.author_id, x.manga_id });
                    table.ForeignKey(
                        name: "FK_author_details_authors_author_id",
                        column: x => x.author_id,
                        principalTable: "authors",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_author_details_collections_manga_id",
                        column: x => x.manga_id,
                        principalTable: "collections",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "chapters",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    title = table.Column<string>(maxLength: 250, nullable: false),
                    summary = table.Column<string>(nullable: true),
                    manga_id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_chapters", x => x.id);
                    table.ForeignKey(
                        name: "FK_chapters_collections_manga_id",
                        column: x => x.manga_id,
                        principalTable: "collections",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "collection_characters",
                columns: table => new
                {
                    character_id = table.Column<int>(nullable: false),
                    collection_id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_collection_characters", x => new { x.character_id, x.collection_id });
                    table.ForeignKey(
                        name: "FK_collection_characters_characters_character_id",
                        column: x => x.character_id,
                        principalTable: "characters",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_collection_characters_collections_collection_id",
                        column: x => x.collection_id,
                        principalTable: "collections",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "episodes",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    title = table.Column<string>(maxLength: 150, nullable: true),
                    summary = table.Column<string>(nullable: true),
                    anime_id = table.Column<int>(nullable: false),
                    air_date = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_episodes", x => x.id);
                    table.ForeignKey(
                        name: "FK_episodes_collections_anime_id",
                        column: x => x.anime_id,
                        principalTable: "collections",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "producer_studio_details",
                columns: table => new
                {
                    producer_id = table.Column<int>(nullable: false),
                    studio_id = table.Column<int>(nullable: false),
                    anime_id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_producer_studio_details", x => new { x.anime_id, x.producer_id, x.studio_id });
                    table.ForeignKey(
                        name: "FK_producer_studio_details_collections_anime_id",
                        column: x => x.anime_id,
                        principalTable: "collections",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_producer_studio_details_producers_producer_id",
                        column: x => x.producer_id,
                        principalTable: "producers",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_producer_studio_details_studios_studio_id",
                        column: x => x.studio_id,
                        principalTable: "studios",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "collection_items",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false),
                    collection_id = table.Column<int>(nullable: false),
                    user_id = table.Column<int>(nullable: false),
                    status = table.Column<string>(type: "varchar(20)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_collection_items", x => new { x.id, x.collection_id, x.user_id });
                    table.ForeignKey(
                        name: "FK_collection_items_collections_collection_id",
                        column: x => x.collection_id,
                        principalTable: "collections",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_collection_items_users_user_id",
                        column: x => x.user_id,
                        principalTable: "users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "reviews",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    description = table.Column<string>(nullable: false),
                    user_id = table.Column<int>(nullable: false),
                    collection_id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_reviews", x => x.id);
                    table.ForeignKey(
                        name: "FK_reviews_collections_collection_id",
                        column: x => x.collection_id,
                        principalTable: "collections",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_reviews_users_user_id",
                        column: x => x.user_id,
                        principalTable: "users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "user_friends",
                columns: table => new
                {
                    user_id = table.Column<int>(nullable: false),
                    friend_id = table.Column<int>(nullable: false),
                    status = table.Column<string>(type: "varchar(20)", nullable: false),
                    invited = table.Column<DateTime>(nullable: true),
                    accepted = table.Column<DateTime>(nullable: true),
                    blocked = table.Column<DateTime>(nullable: true),
                    UserId1 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_user_friends", x => new { x.user_id, x.friend_id, x.status });
                    table.ForeignKey(
                        name: "FK_user_friends_users_friend_id",
                        column: x => x.friend_id,
                        principalTable: "users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_user_friends_users_user_id",
                        column: x => x.user_id,
                        principalTable: "users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_user_friends_users_UserId1",
                        column: x => x.UserId1,
                        principalTable: "users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "voice_actor_details",
                columns: table => new
                {
                    voice_actor_id = table.Column<int>(nullable: false),
                    character_id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_voice_actor_details", x => new { x.voice_actor_id, x.character_id });
                    table.ForeignKey(
                        name: "FK_voice_actor_details_characters_character_id",
                        column: x => x.character_id,
                        principalTable: "characters",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_voice_actor_details_voice_actors_voice_actor_id",
                        column: x => x.voice_actor_id,
                        principalTable: "voice_actors",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_author_details_manga_id",
                table: "author_details",
                column: "manga_id");

            migrationBuilder.CreateIndex(
                name: "IX_chapters_manga_id",
                table: "chapters",
                column: "manga_id");

            migrationBuilder.CreateIndex(
                name: "IX_collection_characters_collection_id",
                table: "collection_characters",
                column: "collection_id");

            migrationBuilder.CreateIndex(
                name: "IX_collection_items_collection_id",
                table: "collection_items",
                column: "collection_id");

            migrationBuilder.CreateIndex(
                name: "IX_collection_items_user_id",
                table: "collection_items",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "IX_episodes_anime_id",
                table: "episodes",
                column: "anime_id");

            migrationBuilder.CreateIndex(
                name: "IX_producer_studio_details_producer_id",
                table: "producer_studio_details",
                column: "producer_id");

            migrationBuilder.CreateIndex(
                name: "IX_producer_studio_details_studio_id",
                table: "producer_studio_details",
                column: "studio_id");

            migrationBuilder.CreateIndex(
                name: "IX_reviews_collection_id",
                table: "reviews",
                column: "collection_id");

            migrationBuilder.CreateIndex(
                name: "IX_reviews_user_id",
                table: "reviews",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "IX_user_friends_friend_id",
                table: "user_friends",
                column: "friend_id");

            migrationBuilder.CreateIndex(
                name: "IX_user_friends_UserId1",
                table: "user_friends",
                column: "UserId1");

            migrationBuilder.CreateIndex(
                name: "IX_voice_actor_details_character_id",
                table: "voice_actor_details",
                column: "character_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "author_details");

            migrationBuilder.DropTable(
                name: "chapters");

            migrationBuilder.DropTable(
                name: "collection_characters");

            migrationBuilder.DropTable(
                name: "collection_items");

            migrationBuilder.DropTable(
                name: "episodes");

            migrationBuilder.DropTable(
                name: "producer_studio_details");

            migrationBuilder.DropTable(
                name: "reviews");

            migrationBuilder.DropTable(
                name: "user_friends");

            migrationBuilder.DropTable(
                name: "voice_actor_details");

            migrationBuilder.DropTable(
                name: "authors");

            migrationBuilder.DropTable(
                name: "producers");

            migrationBuilder.DropTable(
                name: "studios");

            migrationBuilder.DropTable(
                name: "collections");

            migrationBuilder.DropTable(
                name: "users");

            migrationBuilder.DropTable(
                name: "characters");

            migrationBuilder.DropTable(
                name: "voice_actors");
        }
    }
}
