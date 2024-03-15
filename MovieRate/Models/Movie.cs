﻿namespace MovieRate
{
    public class Movie
    {
        // идентификатор
        public int Id { get; set; }

        // название фильма
        public string? Title { get; set; }

        // режиссер
        public string? Director { get; set; }

        // жанр
        public string? Genre { get; set; }

        // год выпуска
        public string? Release { get; set; }

        // постер
        public required Uri Poster { get; set; }

        // краткое описание
        public string? Description { get; set; }
    }
}