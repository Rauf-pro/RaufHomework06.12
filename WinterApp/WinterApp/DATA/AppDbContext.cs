using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WinterApp.Models;

namespace WinterApp.DATA
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions option) : base(option)
        {

        }
        public DbSet<Setting> Settings { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Fasion> Fasions { get; set; }
        public DbSet<HoverCategory> HoverCategories { get; set; }
        public DbSet<HoverToCategory> HoverToCategories { get; set; }
        public DbSet<NewsLetter> NewsLetters { get; set; }
        public DbSet<Login> Logins { get; set; }
        public DbSet<Social> Socials { get; set; }
        public DbSet<ProductDetails> ProductDetails { get; set; }
        public DbSet<SocialToProductDetails> SocialToProductDetails { get; set; }
        public DbSet<Tag> Tags{ get; set; }
        public DbSet<TagToBlog> TagToBlogs { get; set; }
        public DbSet<ShopCategory> ShopCategories{ get; set; }
        public DbSet<Message> Messages{ get; set; }
        




    }
}
