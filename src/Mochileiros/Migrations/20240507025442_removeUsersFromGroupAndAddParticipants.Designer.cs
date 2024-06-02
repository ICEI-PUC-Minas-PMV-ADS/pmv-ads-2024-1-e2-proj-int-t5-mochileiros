using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Mochileiros.Data;

namespace Mochileiros.Migrations
{
    [DbContext(typeof(MochileirosContext))]
    [Migration("20240507025442_RemoveUsersAndChangeToParticipants")]
    public partial class RemoveUsersAndChangeToParticipants : Migration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            #pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.4");

            modelBuilder.Entity("Mochileiros.Models.Expense", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<int>("TravelID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Type")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Value")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("TravelID");

                    b.ToTable("Expense");
                });

            modelBuilder.Entity("Mochileiros.Models.Group", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("NumberOfUsers")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TravelId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Participants")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("TravelId")
                        .IsUnique();

                    b.ToTable("Group");
                });

            modelBuilder.Entity("Mochileiros.Models.Travel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Destination")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("TEXT");

                    b.Property<int?>("GroupId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Image")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("TEXT");

                    b.Property<int>("TravelNumber")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Travel");
                });

            modelBuilder.Entity("Mochileiros.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Image")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Nickname")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("GroupUser", b =>
                {
                    b.HasOne("Mochileiros.Models.Group", null)
                        .WithMany()
                        .HasForeignKey("GroupsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Mochileiros.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UsersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Mochileiros.Models.Expense", b =>
                {
                    b.HasOne("Mochileiros.Models.Travel", "Travel")
                        .WithMany("Expenses")
                        .HasForeignKey("TravelID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Travel");
                });

            modelBuilder.Entity("Mochileiros.Models.Group", b =>
                {
                    b.HasOne("Mochileiros.Models.Travel", "Travel")
                        .WithOne("Group")
                        .HasForeignKey("Mochileiros.Models.Group", "TravelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Travel");
                });

            modelBuilder.Entity("Mochileiros.Models.Travel", b =>
                {
                    b.HasOne("Mochileiros.Models.User", "User")
                        .WithMany("Travels")
                        .HasForeignKey("UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Mochileiros.Models.Travel", b =>
                {
                    b.Navigation("Expenses");

                    b.Navigation("Group");
                });

            modelBuilder.Entity("Mochileiros.Models.User", b =>
                {
                    b.Navigation("Travels");
                });
            #pragma warning restore 612, 618
        }
    }
}
