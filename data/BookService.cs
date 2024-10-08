using System.Collections.Generic;
namespace BlogBookApp.Data{
    public class BookService
    {
        private readonly List<Category> categories;
        public BookService(){
            categories = [
                new Category
                {
                    Name="Fiction",
                    Books=
                    [
                        new Book
                        {
                            Id = 1,
                            Title = "Book One",
                            Author = "Author One",
                            PublicationDate = new DateTime(2023, 6, 1),
                            CoverImageUrl = "https://th.bing.com/th/id/OIP.p5FiMK7c3OR6Tfv_UkfwzgAAAA?rs=1&pid=ImgDetMain.jpg",
                            Description = "Description for book one.",
                            Pages = [@"The rain drummed incessantly against the roof of the old station, each drop a ghostly reminder of the city's relentless decay. 
                                    Detective Grey sat hunched over a flickering light, his coffee cup long cold. His thoughts were as dark as the night outside; 
                                    somewhere out there, the Fortress Blood killer was watching, waiting.",
                                    @"The city of Veridian Heights had seen its fair share of crime, but nothing like this. 
                                    Six bodies, all drained of blood and left in alleyways like offerings to some forgotten god. 
                                    Grey knew the media would have a field day once word got out — if they didn't already have sources leaking it.",
                                    @"Grey pulled out the file on the latest victim. Her name was Emma Crane, a local artist. 
                                    Her last known location: a small art studio down on 5th Street, a place that looked more abandoned than operational. 
                                    As Grey stepped into the building, the air felt thick, like it was holding its breath — waiting for something to happen."]
                        },
                        new Book
                        {
                            Id = 2,
                            Title = "Fortress Blood",
                            Author = "L.D Goggigan",
                            PublicationDate = new DateTime(2023, 6, 1),
                            CoverImageUrl = "https://miblart.com/wp-content/uploads/2020/01/crime-and-mystery-cover-scaled-1.jpeg",
                            Description = "Description for book one.",
                            Pages = [@"The rain drummed incessantly against the roof of the old station, each drop a ghostly reminder of the city's relentless decay. 
                                    Detective Grey sat hunched over a flickering light, his coffee cup long cold. His thoughts were as dark as the night outside; 
                                    somewhere out there, the Fortress Blood killer was watching, waiting.",
                                    @"The city of Veridian Heights had seen its fair share of crime, but nothing like this. 
                                    Six bodies, all drained of blood and left in alleyways like offerings to some forgotten god. 
                                    Grey knew the media would have a field day once word got out — if they didn't already have sources leaking it.",
                                    @"Grey pulled out the file on the latest victim. Her name was Emma Crane, a local artist. 
                                    Her last known location: a small art studio down on 5th Street, a place that looked more abandoned than operational. 
                                    As Grey stepped into the building, the air felt thick, like it was holding its breath — waiting for something to happen."]
                        },
                        new Book
                        {
                            Id = 3,
                            Title = "Fortress Blood",
                            Author = "L.D Goggigan",
                            PublicationDate = new DateTime(2023, 6, 1),
                            CoverImageUrl = "https://miblart.com/wp-content/uploads/2020/01/crime-and-mystery-cover-scaled-1.jpeg",
                            Description = "Description for book one.",
                            Pages = [@"The rain drummed incessantly against the roof of the old station, each drop a ghostly reminder of the city's relentless decay. 
                                    Detective Grey sat hunched over a flickering light, his coffee cup long cold. His thoughts were as dark as the night outside; 
                                    somewhere out there, the Fortress Blood killer was watching, waiting.",
                                    @"The city of Veridian Heights had seen its fair share of crime, but nothing like this. 
                                    Six bodies, all drained of blood and left in alleyways like offerings to some forgotten god. 
                                    Grey knew the media would have a field day once word got out — if they didn't already have sources leaking it.",
                                    @"Grey pulled out the file on the latest victim. Her name was Emma Crane, a local artist. 
                                    Her last known location: a small art studio down on 5th Street, a place that looked more abandoned than operational. 
                                    As Grey stepped into the building, the air felt thick, like it was holding its breath — waiting for something to happen."]
                        },
                        new Book
                        {
                            Id = 4,
                            Title = "Fortress Blood",
                            Author = "L.D Goggigan",
                            PublicationDate = new DateTime(2023, 6, 1),
                            CoverImageUrl = "https://miblart.com/wp-content/uploads/2020/01/crime-and-mystery-cover-scaled-1.jpeg",
                            Description = "Description for book one.",
                            Pages = [@"The rain drummed incessantly against the roof of the old station, each drop a ghostly reminder of the city's relentless decay. 
                                    Detective Grey sat hunched over a flickering light, his coffee cup long cold. His thoughts were as dark as the night outside; 
                                    somewhere out there, the Fortress Blood killer was watching, waiting.",
                                    @"The city of Veridian Heights had seen its fair share of crime, but nothing like this. 
                                    Six bodies, all drained of blood and left in alleyways like offerings to some forgotten god. 
                                    Grey knew the media would have a field day once word got out — if they didn't already have sources leaking it.",
                                    @"Grey pulled out the file on the latest victim. Her name was Emma Crane, a local artist. 
                                    Her last known location: a small art studio down on 5th Street, a place that looked more abandoned than operational. 
                                    As Grey stepped into the building, the air felt thick, like it was holding its breath — waiting for something to happen."]
                        },
                        new Book
                        {
                            Id = 5,
                            Title = "Fortress Blood",
                            Author = "L.D Goggigan",
                            PublicationDate = new DateTime(2023, 6, 1),
                            CoverImageUrl = "https://miblart.com/wp-content/uploads/2020/01/crime-and-mystery-cover-scaled-1.jpeg",
                            Description = "Description for book one.",
                            Pages = [@"The rain drummed incessantly against the roof of the old station, each drop a ghostly reminder of the city's relentless decay. 
                                    Detective Grey sat hunched over a flickering light, his coffee cup long cold. His thoughts were as dark as the night outside; 
                                    somewhere out there, the Fortress Blood killer was watching, waiting.",
                                    @"The city of Veridian Heights had seen its fair share of crime, but nothing like this. 
                                    Six bodies, all drained of blood and left in alleyways like offerings to some forgotten god. 
                                    Grey knew the media would have a field day once word got out — if they didn't already have sources leaking it.",
                                    @"Grey pulled out the file on the latest victim. Her name was Emma Crane, a local artist. 
                                    Her last known location: a small art studio down on 5th Street, a place that looked more abandoned than operational. 
                                    As Grey stepped into the building, the air felt thick, like it was holding its breath — waiting for something to happen."]
                        }
                    ]
                },
                new Category
                {
                    Name="Autobiography",
                    Books=
                    [
                        new Book
                        {
                            Id = 1,
                            Title = "Mandela",
                            Author = "Mandela",
                            PublicationDate = new DateTime(2023, 6, 1),
                            CoverImageUrl = "https://d28hgpri8am2if.cloudfront.net/book_images/cvr9781847399328_9781847399328_lg.jpg",
                            Description = "Description for book one.",
                            Pages = [@"The rain drummed incessantly against the roof of the old station, each drop a ghostly reminder of the city's relentless decay. 
                                    Detective Grey sat hunched over a flickering light, his coffee cup long cold. His thoughts were as dark as the night outside; 
                                    somewhere out there, the Fortress Blood killer was watching, waiting.",
                                    @"The city of Veridian Heights had seen its fair share of crime, but nothing like this. 
                                    Six bodies, all drained of blood and left in alleyways like offerings to some forgotten god. 
                                    Grey knew the media would have a field day once word got out — if they didn't already have sources leaking it.",
                                    @"Grey pulled out the file on the latest victim. Her name was Emma Crane, a local artist. 
                                    Her last known location: a small art studio down on 5th Street, a place that looked more abandoned than operational. 
                                    As Grey stepped into the building, the air felt thick, like it was holding its breath — waiting for something to happen."]
                        },
                        new Book
                        {
                            Id = 2,
                            Title = "Pele: The Autobiography",
                            Author = "Pele",
                            PublicationDate = new DateTime(2023, 6, 1),
                            CoverImageUrl = "https://th.bing.com/th/id/OIP.-4BoEGbpCrwf35SsvLSoMQHaLW?rs=1&pid=ImgDetMain",
                            Description = "Description for book one.",
                            Pages = [@"The rain drummed incessantly against the roof of the old station, each drop a ghostly reminder of the city's relentless decay. 
                                    Detective Grey sat hunched over a flickering light, his coffee cup long cold. His thoughts were as dark as the night outside; 
                                    somewhere out there, the Fortress Blood killer was watching, waiting.",
                                    @"The city of Veridian Heights had seen its fair share of crime, but nothing like this. 
                                    Six bodies, all drained of blood and left in alleyways like offerings to some forgotten god. 
                                    Grey knew the media would have a field day once word got out — if they didn't already have sources leaking it.",
                                    @"Grey pulled out the file on the latest victim. Her name was Emma Crane, a local artist. 
                                    Her last known location: a small art studio down on 5th Street, a place that looked more abandoned than operational. 
                                    As Grey stepped into the building, the air felt thick, like it was holding its breath — waiting for something to happen."]
                        }
                    ]
                }
            ];
        }

    public List<Category> GetCategories()=>categories;
    public Book? GetBookId(int id)=>categories.SelectMany(c=>c.Books!).FirstOrDefault(b=>b.Id==id);
    }

    

    
}