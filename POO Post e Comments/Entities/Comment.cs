using System;
using System.Text;


namespace POO_Post_e_Comments.Entities
{
    class Comment
    {
        public string Text { get; set; }

        #region Contrutores
        public Comment()
        {

        }
        public Comment(string text)
        {
            Text = text;
        }
        #endregion
    }
}
