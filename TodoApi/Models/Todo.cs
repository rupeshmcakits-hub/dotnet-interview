using System;

namespace TodoApi.Models
{
    /// <summary>
    /// Represents a Todo item with details and status.
    /// </summary>
    public class Todo
    {
        /// <summary>
        /// Gets or sets the unique identifier for the Todo item.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the title of the Todo item.
        /// </summary>
        public string? Title { get; set; }

        /// <summary>
        /// Gets or sets the description of the Todo item.
        /// </summary>
        public string? Description { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the Todo item is completed.
        /// </summary>
        public bool IsCompleted { get; set; }

        /// <summary>
        /// Gets or sets the creation date and time of the Todo item.
        /// </summary>
        public DateTime CreatedAt { get; set; }
    }
}
