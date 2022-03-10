using System;
using System.Collections.Generic;
using System.Text;
using POO_Post_e_Comments.Entities;


namespace POO_Post_e_Comments.Entities
{
    class Post
    {
        public DateTime Moment { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int Likes { get; set; }

        public List<Comment> Comments { get; set; } = new List<Comment>();
        #region Contrutores
        public Post()
        {

        }

        public Post(DateTime moment, string title, string content, int likes)
        {
            Moment = moment;
            Title = title;
            Content = content;
            Likes = likes;

        }
        #endregion
        #region Métodos
        public void AddComment(Comment comment)
        {
            Comments.Add(comment);
        }
        public void RemoveComment(Comment comment)
        {
            Comments.Remove(comment);
        }
        #endregion
        #region ToString 
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder(); // Pertence a system.Text

            sb.AppendLine(Title);
            sb.Append(Likes);
            sb.Append(" Likes - ");
            sb.AppendLine(Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine(Content);
            sb.AppendLine("Coments:");
            foreach (Comment c in Comments)
            {
                sb.AppendLine(c.Text);
            }

            return sb.ToString();
        }
        #endregion
    }
}
