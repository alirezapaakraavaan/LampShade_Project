﻿namespace CommentManagement.Application.Contracts.Comment
{
    public class CommentViewModel : AddComment
    {
        public long Id { get; set; }
        public string ProductName { get; set; }
        public bool IsConfirmed { get; set; }
        public bool IsCanceled { get; set; }
        public string CommentDate { get; set; }
        public string Website { get; set; }
        public long OwnerRecordId { get; set; }
        public string OwnerName { get; set; }
        public int Type { get; set; }
    }
}