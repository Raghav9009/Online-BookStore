﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using server.Models.DB;

#nullable disable

namespace server.Migrations
{
    [DbContext(typeof(BookStoreDbContext))]
    [Migration("20240829044624_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BookTag", b =>
                {
                    b.Property<int>("BookId")
                        .HasColumnType("int")
                        .HasColumnName("book_id");

                    b.Property<int>("TagId")
                        .HasColumnType("int")
                        .HasColumnName("tag_id");

                    b.HasKey("BookId", "TagId")
                        .HasName("PK__BookTag__3D2470CACC5A9021");

                    b.HasIndex("TagId");

                    b.ToTable("BookTag", (string)null);
                });

            modelBuilder.Entity("server.Models.DB.Author", b =>
                {
                    b.Property<int>("AuthorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("author_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AuthorId"));

                    b.Property<string>("AuthorName")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("author_name");

                    b.Property<string>("Bio")
                        .HasColumnType("text")
                        .HasColumnName("bio");

                    b.HasKey("AuthorId")
                        .HasName("PK__Authors__86516BCFA24EBAF7");

                    b.ToTable("Authors");
                });

            modelBuilder.Entity("server.Models.DB.Book", b =>
                {
                    b.Property<int>("BookId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("book_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BookId"));

                    b.Property<int?>("AuthorId")
                        .HasColumnType("int")
                        .HasColumnName("author_id");

                    b.Property<string>("Description")
                        .HasColumnType("text")
                        .HasColumnName("description");

                    b.Property<string>("ImageUrl")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("image_url");

                    b.Property<string>("Language")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("language");

                    b.Property<int?>("PagesCount")
                        .HasColumnType("int")
                        .HasColumnName("pages_count");

                    b.Property<decimal?>("Price")
                        .HasColumnType("money")
                        .HasColumnName("price");

                    b.Property<DateOnly?>("PublishedDate")
                        .HasColumnType("date")
                        .HasColumnName("published_date");

                    b.Property<double?>("PublishedVersion")
                        .HasColumnType("float")
                        .HasColumnName("published_version");

                    b.Property<int?>("PublisherId")
                        .HasColumnType("int")
                        .HasColumnName("publisher_id");

                    b.Property<string>("Title")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("title");

                    b.HasKey("BookId")
                        .HasName("PK__Books__490D1AE1A84A3ED0");

                    b.HasIndex("AuthorId");

                    b.HasIndex("PublisherId");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("server.Models.DB.Cart", b =>
                {
                    b.Property<int>("CartId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("cart_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CartId"));

                    b.Property<int?>("BookId")
                        .HasColumnType("int")
                        .HasColumnName("book_id");

                    b.Property<int?>("Quantity")
                        .HasColumnType("int")
                        .HasColumnName("quantity");

                    b.Property<int?>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("user_id");

                    b.HasKey("CartId")
                        .HasName("PK__Carts__2EF52A27B9CE3939");

                    b.HasIndex("BookId");

                    b.HasIndex("UserId");

                    b.ToTable("Carts");
                });

            modelBuilder.Entity("server.Models.DB.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("order_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrderId"));

                    b.Property<DateOnly?>("OrderDate")
                        .HasColumnType("date")
                        .HasColumnName("order_date");

                    b.Property<int?>("PaymentId")
                        .HasColumnType("int")
                        .HasColumnName("payment_id");

                    b.Property<int?>("Total")
                        .HasColumnType("int")
                        .HasColumnName("total");

                    b.Property<int?>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("user_id");

                    b.HasKey("OrderId")
                        .HasName("PK__Orders__465962298B4F3117");

                    b.HasIndex("PaymentId");

                    b.HasIndex("UserId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("server.Models.DB.OrderItem", b =>
                {
                    b.Property<int>("OrderItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("order_item_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrderItemId"));

                    b.Property<int?>("BookId")
                        .HasColumnType("int")
                        .HasColumnName("book_id");

                    b.Property<int?>("OrderId")
                        .HasColumnType("int")
                        .HasColumnName("order_id");

                    b.Property<int?>("Quantity")
                        .HasColumnType("int")
                        .HasColumnName("quantity");

                    b.HasKey("OrderItemId")
                        .HasName("PK__Order_it__3764B6BC850F45D3");

                    b.HasIndex("BookId");

                    b.HasIndex("OrderId");

                    b.ToTable("Order_items", (string)null);
                });

            modelBuilder.Entity("server.Models.DB.Payment", b =>
                {
                    b.Property<int>("PaymentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("payment_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PaymentId"));

                    b.Property<decimal?>("Amount")
                        .HasColumnType("money")
                        .HasColumnName("amount");

                    b.Property<string>("PaymentType")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("payment_type");

                    b.Property<string>("Status")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("status");

                    b.HasKey("PaymentId")
                        .HasName("PK__Payments__ED1FC9EA0B9BA1AD");

                    b.ToTable("Payments");
                });

            modelBuilder.Entity("server.Models.DB.Publisher", b =>
                {
                    b.Property<int>("PublisherId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("publisher_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PublisherId"));

                    b.Property<string>("PublisherAddress")
                        .HasColumnType("text")
                        .HasColumnName("publisher_address");

                    b.Property<string>("PublisherName")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("publisher_name");

                    b.HasKey("PublisherId")
                        .HasName("PK__Publishe__3263F29DAFF3A768");

                    b.ToTable("Publishers");
                });

            modelBuilder.Entity("server.Models.DB.Review", b =>
                {
                    b.Property<int>("ReviewId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("review_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ReviewId"));

                    b.Property<int?>("BookId")
                        .HasColumnType("int")
                        .HasColumnName("book_id");

                    b.Property<int?>("Rating")
                        .HasColumnType("int")
                        .HasColumnName("rating");

                    b.Property<string>("Review1")
                        .HasMaxLength(300)
                        .IsUnicode(false)
                        .HasColumnType("varchar(300)")
                        .HasColumnName("review");

                    b.Property<DateOnly?>("ReviewedDate")
                        .HasColumnType("date")
                        .HasColumnName("reviewed_date");

                    b.Property<int?>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("user_id");

                    b.HasKey("ReviewId")
                        .HasName("PK__Reviews__60883D90FB2C6292");

                    b.HasIndex("BookId");

                    b.HasIndex("UserId");

                    b.ToTable("Reviews");
                });

            modelBuilder.Entity("server.Models.DB.Tag", b =>
                {
                    b.Property<int>("TagId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("tag_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TagId"));

                    b.Property<string>("Tag1")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("tag");

                    b.HasKey("TagId")
                        .HasName("PK__Tags__4296A2B663E5BFA0");

                    b.ToTable("Tags");
                });

            modelBuilder.Entity("server.Models.DB.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("user_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"));

                    b.Property<string>("Address")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)")
                        .HasColumnName("address");

                    b.Property<string>("Contact")
                        .HasMaxLength(15)
                        .IsUnicode(false)
                        .HasColumnType("varchar(15)")
                        .HasColumnName("contact");

                    b.Property<string>("Email")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("email");

                    b.Property<string>("Name")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("name");

                    b.Property<string>("Password")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("password");

                    b.Property<string>("PinCode")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("pin_code");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("role");

                    b.HasKey("UserId")
                        .HasName("PK__Users__B9BE370F0B2D23E4");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("BookTag", b =>
                {
                    b.HasOne("server.Models.DB.Book", null)
                        .WithMany()
                        .HasForeignKey("BookId")
                        .IsRequired()
                        .HasConstraintName("FK__BookTag__book_id__440B1D61");

                    b.HasOne("server.Models.DB.Tag", null)
                        .WithMany()
                        .HasForeignKey("TagId")
                        .IsRequired()
                        .HasConstraintName("FK__BookTag__tag_id__44FF419A");
                });

            modelBuilder.Entity("server.Models.DB.Book", b =>
                {
                    b.HasOne("server.Models.DB.Author", "Author")
                        .WithMany("Books")
                        .HasForeignKey("AuthorId")
                        .HasConstraintName("FK__Books__author_id__3B75D760");

                    b.HasOne("server.Models.DB.Publisher", "Publisher")
                        .WithMany("Books")
                        .HasForeignKey("PublisherId")
                        .HasConstraintName("FK__Books__publisher__3C69FB99");

                    b.Navigation("Author");

                    b.Navigation("Publisher");
                });

            modelBuilder.Entity("server.Models.DB.Cart", b =>
                {
                    b.HasOne("server.Models.DB.Book", "Book")
                        .WithMany("Carts")
                        .HasForeignKey("BookId")
                        .HasConstraintName("FK__Carts__book_id__534D60F1");

                    b.HasOne("server.Models.DB.User", "User")
                        .WithMany("Carts")
                        .HasForeignKey("UserId")
                        .HasConstraintName("FK__Carts__user_id__5441852A");

                    b.Navigation("Book");

                    b.Navigation("User");
                });

            modelBuilder.Entity("server.Models.DB.Order", b =>
                {
                    b.HasOne("server.Models.DB.Payment", "Payment")
                        .WithMany("Orders")
                        .HasForeignKey("PaymentId")
                        .HasConstraintName("FK__Orders__payment___4BAC3F29");

                    b.HasOne("server.Models.DB.User", "User")
                        .WithMany("Orders")
                        .HasForeignKey("UserId")
                        .HasConstraintName("FK__Orders__user_id__4AB81AF0");

                    b.Navigation("Payment");

                    b.Navigation("User");
                });

            modelBuilder.Entity("server.Models.DB.OrderItem", b =>
                {
                    b.HasOne("server.Models.DB.Book", "Book")
                        .WithMany("OrderItems")
                        .HasForeignKey("BookId")
                        .HasConstraintName("FK__Order_ite__book___5812160E");

                    b.HasOne("server.Models.DB.Order", "Order")
                        .WithMany("OrderItems")
                        .HasForeignKey("OrderId")
                        .HasConstraintName("FK__Order_ite__order__571DF1D5");

                    b.Navigation("Book");

                    b.Navigation("Order");
                });

            modelBuilder.Entity("server.Models.DB.Review", b =>
                {
                    b.HasOne("server.Models.DB.Book", "Book")
                        .WithMany("Reviews")
                        .HasForeignKey("BookId")
                        .HasConstraintName("FK__Reviews__book_id__4E88ABD4");

                    b.HasOne("server.Models.DB.User", "User")
                        .WithMany("Reviews")
                        .HasForeignKey("UserId")
                        .HasConstraintName("FK__Reviews__user_id__4F7CD00D");

                    b.Navigation("Book");

                    b.Navigation("User");
                });

            modelBuilder.Entity("server.Models.DB.Author", b =>
                {
                    b.Navigation("Books");
                });

            modelBuilder.Entity("server.Models.DB.Book", b =>
                {
                    b.Navigation("Carts");

                    b.Navigation("OrderItems");

                    b.Navigation("Reviews");
                });

            modelBuilder.Entity("server.Models.DB.Order", b =>
                {
                    b.Navigation("OrderItems");
                });

            modelBuilder.Entity("server.Models.DB.Payment", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("server.Models.DB.Publisher", b =>
                {
                    b.Navigation("Books");
                });

            modelBuilder.Entity("server.Models.DB.User", b =>
                {
                    b.Navigation("Carts");

                    b.Navigation("Orders");

                    b.Navigation("Reviews");
                });
#pragma warning restore 612, 618
        }
    }
}
