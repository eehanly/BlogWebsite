using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;


    public class AppUser : IdentityUser {
        public string? AuthorName {get; set;}
        public IEnumerable<Blog> Blogs {get; set;}
    }
