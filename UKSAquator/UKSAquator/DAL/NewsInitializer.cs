using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;
using UKSAquator.Models;

namespace UKSAquator.DAL
{
    public class NewsInitializer : DropCreateDatabaseAlways<NewsContext>
    {
        protected override void Seed(NewsContext context)
        {
            SeedNewsData(context);
            SeedGalleryData(context);

            base.Seed(context);
        }

        private void SeedNewsData(NewsContext context)
        {
            var news = new List<News>
            {
                new News() {NewsTitle = "Mistrzostwa kobiet w stylu jakimś tam", Description="Ut arcu enim, dictum quis ultrices id, sagittis eget nulla sed nunc mi, congue ut ultricies ac, varius a eros donec porttitor, libero fermentum fringilla laoreet, eros arcu sodales ante, ut dictum risus lectus vel quam integer ultricies, nunc eget elementum euismod, orci enim vestibulum orci, nec suscipit urna odio et tellus suspendisse suscipit orci sit amet sem venenatis nec lobortis sem suscipit nullam nec imperdiet velit mauris eu nisi a felis imperdiet porta at ac nulla vivamus faucibus felis nec dolor pretium eget pellentesque dolor suscipit maecenas vitae enim arcu, at tincidunt nunc pellentesque eleifend vulputate lacus, vel semper sem ornare sit amet proin sem sapien, auctor vel faucibus id, aliquet vitae ipsum etiam auctor ultricies ante, at dapibus urna viverra sed nullam mi arcu, tempor vitae interdum a, sodales non urna vestibulum dignissim auctor mauris, ac elementum purus fermentum vitae duis placerat laoreet risus, sit amet eleifend tellus lobortis non vivamus iaculis dapibus leo a ornare cras vel sem at felis convallis mollis posuere ultrices dolor sed tellus arcu, accumsan a consectetur sit amet, volutpat eget lorem phasellus quis ipsum orci integer sodales tincidunt nibh a elementum ut ac libero nec orci euismod euismod nec at nulla duis.", CountryEvent = "Polska", CityEvent = "Kozienice", StartDateEvent = DateTime.Parse("12/02/2020"), EndDateEvent = DateTime.Parse("14/02/2020"), PublicationDate = DateTime.Now, CoverFileName = "IMG-20210304-WA0000.jpg", IsHidden = false },
                new News() {NewsTitle = "Mistrzostwa mężczyzn w stylu jakimś tam", Description="Ut arcu enim, dictum quis ultrices id, sagittis eget nulla sed nunc mi, congue ut ultricies ac, varius a eros donec porttitor, libero fermentum fringilla laoreet, eros arcu sodales ante, ut dictum risus lectus vel quam integer ultricies, nunc eget elementum euismod, orci enim vestibulum orci, nec suscipit urna odio et tellus suspendisse suscipit orci sit amet sem venenatis nec lobortis sem suscipit nullam nec imperdiet velit mauris eu nisi a felis imperdiet porta at ac nulla vivamus faucibus felis nec dolor pretium eget pellentesque dolor suscipit maecenas vitae enim arcu, at tincidunt nunc pellentesque eleifend vulputate lacus, vel semper sem ornare sit amet proin sem sapien, auctor vel faucibus id, aliquet vitae ipsum etiam auctor ultricies ante, at dapibus urna viverra sed nullam mi arcu, tempor vitae interdum a, sodales non urna vestibulum dignissim auctor mauris, ac elementum purus fermentum vitae duis placerat laoreet risus, sit amet eleifend tellus lobortis non vivamus iaculis dapibus leo a ornare cras vel sem at felis convallis mollis posuere ultrices dolor sed tellus arcu, accumsan a consectetur sit amet, volutpat eget lorem phasellus quis ipsum orci integer sodales tincidunt nibh a elementum ut ac libero nec orci euismod euismod nec at nulla duis.", CountryEvent = "Polska", CityEvent = "Warszawa", StartDateEvent = DateTime.Parse("12/01/2020"), EndDateEvent = DateTime.Parse("14/01/2020"), PublicationDate = DateTime.Now, CoverFileName = "IMG-20210304-WA0001.jpg", IsHidden = false },
                new News() {NewsTitle = "Mistrzostwa dzieci 8-12 lat", Description="Ut arcu enim, dictum quis ultrices id, sagittis eget nulla sed nunc mi, congue ut ultricies ac, varius a eros donec porttitor, libero fermentum fringilla laoreet, eros arcu sodales ante, ut dictum risus lectus vel quam integer ultricies, nunc eget elementum euismod, orci enim vestibulum orci, nec suscipit urna odio et tellus suspendisse suscipit orci sit amet sem venenatis nec lobortis sem suscipit nullam nec imperdiet velit mauris eu nisi a felis imperdiet porta at ac nulla vivamus faucibus felis nec dolor pretium eget pellentesque dolor suscipit maecenas vitae enim arcu, at tincidunt nunc pellentesque eleifend vulputate lacus, vel semper sem ornare sit amet proin sem sapien, auctor vel faucibus id, aliquet vitae ipsum etiam auctor ultricies ante, at dapibus urna viverra sed nullam mi arcu, tempor vitae interdum a, sodales non urna vestibulum dignissim auctor mauris, ac elementum purus fermentum vitae duis placerat laoreet risus, sit amet eleifend tellus lobortis non vivamus iaculis dapibus leo a ornare cras vel sem at felis convallis mollis posuere ultrices dolor sed tellus arcu, accumsan a consectetur sit amet, volutpat eget lorem phasellus quis ipsum orci integer sodales tincidunt nibh a elementum ut ac libero nec orci euismod euismod nec at nulla duis.", CountryEvent = "Polska", CityEvent = "Kozienice", StartDateEvent = DateTime.Parse("01/06/2020"), EndDateEvent = DateTime.Parse("24/06/2020"), PublicationDate = DateTime.Now, CoverFileName = "IMG-20210304-WA0002.jpg", IsHidden = false },
                new News() {NewsTitle = "Mistrzostwa kobiet w stylu kraul", Description="Ut arcu enim, dictum quis ultrices id, sagittis eget nulla sed nunc mi, congue ut ultricies ac, varius a eros donec porttitor, libero fermentum fringilla laoreet, eros arcu sodales ante, ut dictum risus lectus vel quam integer ultricies, nunc eget elementum euismod, orci enim vestibulum orci, nec suscipit urna odio et tellus suspendisse suscipit orci sit amet sem venenatis nec lobortis sem suscipit nullam nec imperdiet velit mauris eu nisi a felis imperdiet porta at ac nulla vivamus faucibus felis nec dolor pretium eget pellentesque dolor suscipit maecenas vitae enim arcu, at tincidunt nunc pellentesque eleifend vulputate lacus, vel semper sem ornare sit amet proin sem sapien, auctor vel faucibus id, aliquet vitae ipsum etiam auctor ultricies ante, at dapibus urna viverra sed nullam mi arcu, tempor vitae interdum a, sodales non urna vestibulum dignissim auctor mauris, ac elementum purus fermentum vitae duis placerat laoreet risus, sit amet eleifend tellus lobortis non vivamus iaculis dapibus leo a ornare cras vel sem at felis convallis mollis posuere ultrices dolor sed tellus arcu, accumsan a consectetur sit amet, volutpat eget lorem phasellus quis ipsum orci integer sodales tincidunt nibh a elementum ut ac libero nec orci euismod euismod nec at nulla duis.", CountryEvent = "Polska", CityEvent = "Radom", StartDateEvent = DateTime.Parse("12/05/2020"), EndDateEvent = DateTime.Parse("14/02/2020"), PublicationDate = DateTime.Now, CoverFileName = "IMG-20210304-WA0003.jpg", IsHidden = false },
                new News() {NewsTitle = "Wspinaczka młodzieży PG2 w Kozienicach", Description="Ut arcu enim, dictum quis ultrices id, sagittis eget nulla sed nunc mi, congue ut ultricies ac, varius a eros donec porttitor, libero fermentum fringilla laoreet, eros arcu sodales ante, ut dictum risus lectus vel quam integer ultricies, nunc eget elementum euismod, orci enim vestibulum orci, nec suscipit urna odio et tellus suspendisse suscipit orci sit amet sem venenatis nec lobortis sem suscipit nullam nec imperdiet velit mauris eu nisi a felis imperdiet porta at ac nulla vivamus faucibus felis nec dolor pretium eget pellentesque dolor suscipit maecenas vitae enim arcu, at tincidunt nunc pellentesque eleifend vulputate lacus, vel semper sem ornare sit amet proin sem sapien, auctor vel faucibus id, aliquet vitae ipsum etiam auctor ultricies ante, at dapibus urna viverra sed nullam mi arcu, tempor vitae interdum a, sodales non urna vestibulum dignissim auctor mauris, ac elementum purus fermentum vitae duis placerat laoreet risus, sit amet eleifend tellus lobortis non vivamus iaculis dapibus leo a ornare cras vel sem at felis convallis mollis posuere ultrices dolor sed tellus arcu, accumsan a consectetur sit amet, volutpat eget lorem phasellus quis ipsum orci integer sodales tincidunt nibh a elementum ut ac libero nec orci euismod euismod nec at nulla duis.", CountryEvent = "Polska", CityEvent = "Kozienice", StartDateEvent = DateTime.Parse("12/02/2020"), EndDateEvent = DateTime.Parse("14/02/2020"), PublicationDate = DateTime.Now, CoverFileName = "IMG-20210304-WA0004.jpg", IsHidden = false },
                new News() {NewsTitle = "Biba nad jeziorem - wóda FREE", Description="Ut arcu enim, dictum quis ultrices id, sagittis eget nulla sed nunc mi, congue ut ultricies ac, varius a eros donec porttitor, libero fermentum fringilla laoreet, eros arcu sodales ante, ut dictum risus lectus vel quam integer ultricies, nunc eget elementum euismod, orci enim vestibulum orci, nec suscipit urna odio et tellus suspendisse suscipit orci sit amet sem venenatis nec lobortis sem suscipit nullam nec imperdiet velit mauris eu nisi a felis imperdiet porta at ac nulla vivamus faucibus felis nec dolor pretium eget pellentesque dolor suscipit maecenas vitae enim arcu, at tincidunt nunc pellentesque eleifend vulputate lacus, vel semper sem ornare sit amet proin sem sapien, auctor vel faucibus id, aliquet vitae ipsum etiam auctor ultricies ante, at dapibus urna viverra sed nullam mi arcu, tempor vitae interdum a, sodales non urna vestibulum dignissim auctor mauris, ac elementum purus fermentum vitae duis placerat laoreet risus, sit amet eleifend tellus lobortis non vivamus iaculis dapibus leo a ornare cras vel sem at felis convallis mollis posuere ultrices dolor sed tellus arcu, accumsan a consectetur sit amet, volutpat eget lorem phasellus quis ipsum orci integer sodales tincidunt nibh a elementum ut ac libero nec orci euismod euismod nec at nulla duis.", CountryEvent = "Polska", CityEvent = "Płock", StartDateEvent = DateTime.Parse("12/02/2020"), EndDateEvent = DateTime.Parse("14/02/2020"), PublicationDate = DateTime.Now, CoverFileName = "IMG-20210304-WA0005.jpg", IsHidden = false },
                new News() {NewsTitle = "NOWY TEAM młodzieży Kozienickiej - impreza w Zielonej Górze", Description="Ut arcu enim, dictum quis ultrices id, sagittis eget nulla sed nunc mi, congue ut ultricies ac, varius a eros donec porttitor, libero fermentum fringilla laoreet, eros arcu sodales ante, ut dictum risus lectus vel quam integer ultricies, nunc eget elementum euismod, orci enim vestibulum orci, nec suscipit urna odio et tellus suspendisse suscipit orci sit amet sem venenatis nec lobortis sem suscipit nullam nec imperdiet velit mauris eu nisi a felis imperdiet porta at ac nulla vivamus faucibus felis nec dolor pretium eget pellentesque dolor suscipit maecenas vitae enim arcu, at tincidunt nunc pellentesque eleifend vulputate lacus, vel semper sem ornare sit amet proin sem sapien, auctor vel faucibus id, aliquet vitae ipsum etiam auctor ultricies ante, at dapibus urna viverra sed nullam mi arcu, tempor vitae interdum a, sodales non urna vestibulum dignissim auctor mauris, ac elementum purus fermentum vitae duis placerat laoreet risus, sit amet eleifend tellus lobortis non vivamus iaculis dapibus leo a ornare cras vel sem at felis convallis mollis posuere ultrices dolor sed tellus arcu, accumsan a consectetur sit amet, volutpat eget lorem phasellus quis ipsum orci integer sodales tincidunt nibh a elementum ut ac libero nec orci euismod euismod nec at nulla duis.", CountryEvent = "Polska", CityEvent = "Zielona Góra", StartDateEvent = DateTime.Parse("12/02/2020"), EndDateEvent = DateTime.Parse("14/02/2020"), PublicationDate = DateTime.Now, CoverFileName = "IMG-20210304-WA0006.jpg", IsHidden = false },
                new News() {NewsTitle = "Bieg po alko - 3km!", Description="Ut arcu enim, dictum quis ultrices id, sagittis eget nulla sed nunc mi, congue ut ultricies ac, varius a eros donec porttitor, libero fermentum fringilla laoreet, eros arcu sodales ante, ut dictum risus lectus vel quam integer ultricies, nunc eget elementum euismod, orci enim vestibulum orci, nec suscipit urna odio et tellus suspendisse suscipit orci sit amet sem venenatis nec lobortis sem suscipit nullam nec imperdiet velit mauris eu nisi a felis imperdiet porta at ac nulla vivamus faucibus felis nec dolor pretium eget pellentesque dolor suscipit maecenas vitae enim arcu, at tincidunt nunc pellentesque eleifend vulputate lacus, vel semper sem ornare sit amet proin sem sapien, auctor vel faucibus id, aliquet vitae ipsum etiam auctor ultricies ante, at dapibus urna viverra sed nullam mi arcu, tempor vitae interdum a, sodales non urna vestibulum dignissim auctor mauris, ac elementum purus fermentum vitae duis placerat laoreet risus, sit amet eleifend tellus lobortis non vivamus iaculis dapibus leo a ornare cras vel sem at felis convallis mollis posuere ultrices dolor sed tellus arcu, accumsan a consectetur sit amet, volutpat eget lorem phasellus quis ipsum orci integer sodales tincidunt nibh a elementum ut ac libero nec orci euismod euismod nec at nulla duis.", CountryEvent = "Polska", CityEvent = "Kozienice", StartDateEvent = DateTime.Parse("12/02/2020"), EndDateEvent = DateTime.Parse("14/02/2020"), PublicationDate = DateTime.Now, CoverFileName = "IMG-20210304-WA0007.jpg", IsHidden = false },
                new News() {NewsTitle = "Zawody narciarskie - czarny szlak Masterów", Description="Ut arcu enim, dictum quis ultrices id, sagittis eget nulla sed nunc mi, congue ut ultricies ac, varius a eros donec porttitor, libero fermentum fringilla laoreet, eros arcu sodales ante, ut dictum risus lectus vel quam integer ultricies, nunc eget elementum euismod, orci enim vestibulum orci, nec suscipit urna odio et tellus suspendisse suscipit orci sit amet sem venenatis nec lobortis sem suscipit nullam nec imperdiet velit mauris eu nisi a felis imperdiet porta at ac nulla vivamus faucibus felis nec dolor pretium eget pellentesque dolor suscipit maecenas vitae enim arcu, at tincidunt nunc pellentesque eleifend vulputate lacus, vel semper sem ornare sit amet proin sem sapien, auctor vel faucibus id, aliquet vitae ipsum etiam auctor ultricies ante, at dapibus urna viverra sed nullam mi arcu, tempor vitae interdum a, sodales non urna vestibulum dignissim auctor mauris, ac elementum purus fermentum vitae duis placerat laoreet risus, sit amet eleifend tellus lobortis non vivamus iaculis dapibus leo a ornare cras vel sem at felis convallis mollis posuere ultrices dolor sed tellus arcu, accumsan a consectetur sit amet, volutpat eget lorem phasellus quis ipsum orci integer sodales tincidunt nibh a elementum ut ac libero nec orci euismod euismod nec at nulla duis.", CountryEvent = "Polska", CityEvent = "Garbatka-Letnisko", StartDateEvent = DateTime.Parse("12/02/2020"), EndDateEvent = DateTime.Parse("14/02/2020"), PublicationDate = DateTime.Now, CoverFileName = "IMG-20210304-WA0008.jpg", IsHidden = false }
            };

            news.ForEach(g => context.DbNews.Add(g));
            context.SaveChanges();
        }

        private void SeedGalleryData(NewsContext context)
        {
            var gallery = new List<Gallery>
            {
                new Gallery() {GalleryId = 1, GalleryFileName="IMG-20210304-WA0000.jpg", NewsId = 1},
                new Gallery() {GalleryId = 1, GalleryFileName="IMG-20210304-WA0001.jpg", NewsId = 1},
                new Gallery() {GalleryId = 1, GalleryFileName="IMG-20210304-WA0002.jpg", NewsId = 1},
                 new Gallery() {GalleryId = 1, GalleryFileName="IMG-20210304-WA0000.jpg", NewsId = 1},
                new Gallery() {GalleryId = 1, GalleryFileName="IMG-20210304-WA0001.jpg", NewsId = 1},
                new Gallery() {GalleryId = 1, GalleryFileName="IMG-20210304-WA0002.jpg", NewsId = 1},
                 new Gallery() {GalleryId = 1, GalleryFileName="IMG-20210304-WA0000.jpg", NewsId = 1},
                new Gallery() {GalleryId = 1, GalleryFileName="IMG-20210304-WA0001.jpg", NewsId = 1},
                new Gallery() {GalleryId = 1, GalleryFileName="IMG-20210304-WA0002.jpg", NewsId = 1},
                 new Gallery() {GalleryId = 1, GalleryFileName="IMG-20210304-WA0000.jpg", NewsId = 1},
                new Gallery() {GalleryId = 1, GalleryFileName="IMG-20210304-WA0001.jpg", NewsId = 1},
                new Gallery() {GalleryId = 1, GalleryFileName="IMG-20210304-WA0002.jpg", NewsId = 1},
                 new Gallery() {GalleryId = 1, GalleryFileName="IMG-20210304-WA0000.jpg", NewsId = 1},
                new Gallery() {GalleryId = 1, GalleryFileName="IMG-20210304-WA0001.jpg", NewsId = 1},
                new Gallery() {GalleryId = 1, GalleryFileName="IMG-20210304-WA0002.jpg", NewsId = 1},
                 new Gallery() {GalleryId = 1, GalleryFileName="IMG-20210304-WA0000.jpg", NewsId = 1},
                new Gallery() {GalleryId = 1, GalleryFileName="IMG-20210304-WA0001.jpg", NewsId = 1},
                new Gallery() {GalleryId = 1, GalleryFileName="IMG-20210304-WA0002.jpg", NewsId = 1},
                 new Gallery() {GalleryId = 1, GalleryFileName="IMG-20210304-WA0000.jpg", NewsId = 1},
                new Gallery() {GalleryId = 1, GalleryFileName="IMG-20210304-WA0001.jpg", NewsId = 1},
                new Gallery() {GalleryId = 1, GalleryFileName="IMG-20210304-WA0002.jpg", NewsId = 1},
                 new Gallery() {GalleryId = 1, GalleryFileName="IMG-20210304-WA0000.jpg", NewsId = 1},
                new Gallery() {GalleryId = 1, GalleryFileName="IMG-20210304-WA0001.jpg", NewsId = 1},
                new Gallery() {GalleryId = 1, GalleryFileName="IMG-20210304-WA0002.jpg", NewsId = 1},
                 new Gallery() {GalleryId = 1, GalleryFileName="IMG-20210304-WA0000.jpg", NewsId = 1},
                new Gallery() {GalleryId = 1, GalleryFileName="IMG-20210304-WA0001.jpg", NewsId = 1},
                new Gallery() {GalleryId = 1, GalleryFileName="IMG-20210304-WA0002.jpg", NewsId = 1},
                 new Gallery() {GalleryId = 1, GalleryFileName="IMG-20210304-WA0000.jpg", NewsId = 1},
                new Gallery() {GalleryId = 1, GalleryFileName="IMG-20210304-WA0001.jpg", NewsId = 1},
                new Gallery() {GalleryId = 1, GalleryFileName="IMG-20210304-WA0002.jpg", NewsId = 1},

                new Gallery() {GalleryId = 2, GalleryFileName="IMG-20210304-WA0000.jpg", NewsId = 2},
                new Gallery() {GalleryId = 2, GalleryFileName="IMG-20210304-WA0003.jpg", NewsId = 2},
                new Gallery() {GalleryId = 2, GalleryFileName="IMG-20210304-WA0004.jpg", NewsId = 2},

                new Gallery() {GalleryId = 3, GalleryFileName="IMG-20210304-WA0005.jpg", NewsId = 3},
                new Gallery() {GalleryId = 3, GalleryFileName="IMG-20210304-WA0006.jpg", NewsId = 3},
                new Gallery() {GalleryId = 3, GalleryFileName="IMG-20210304-WA0008.jpg", NewsId = 3},

                new Gallery() {GalleryId = 4, GalleryFileName="IMG-20210304-WA0007.jpg", NewsId = 4},
                new Gallery() {GalleryId = 4, GalleryFileName="IMG-20210304-WA0008.jpg", NewsId = 4},
                new Gallery() {GalleryId = 4, GalleryFileName="IMG-20210304-WA0002.jpg", NewsId = 4},

                new Gallery() {GalleryId = 5, GalleryFileName="IMG-20210304-WA0002.jpg", NewsId = 5},
                new Gallery() {GalleryId = 5, GalleryFileName="IMG-20210304-WA0004.jpg", NewsId = 5},
                new Gallery() {GalleryId = 5, GalleryFileName="IMG-20210304-WA0006.jpg", NewsId = 5},

                new Gallery() {GalleryId = 6, GalleryFileName="IMG-20210304-WA0000.jpg", NewsId = 6},
                new Gallery() {GalleryId = 6, GalleryFileName="IMG-20210304-WA0001.jpg", NewsId = 6},
                new Gallery() {GalleryId = 6, GalleryFileName="IMG-20210304-WA0002.jpg", NewsId = 6},

                new Gallery() {GalleryId = 7, GalleryFileName="IMG-20210304-WA0000.jpg", NewsId = 7},
                new Gallery() {GalleryId = 7, GalleryFileName="IMG-20210304-WA0003.jpg", NewsId = 7},
                new Gallery() {GalleryId = 7, GalleryFileName="IMG-20210304-WA0004.jpg", NewsId = 7},

                new Gallery() {GalleryId = 8, GalleryFileName="IMG-20210304-WA0005.jpg", NewsId = 8},
                new Gallery() {GalleryId = 8, GalleryFileName="IMG-20210304-WA0006.jpg", NewsId = 8},
                new Gallery() {GalleryId = 8, GalleryFileName="IMG-20210304-WA0008.jpg", NewsId = 8},

                new Gallery() {GalleryId = 9, GalleryFileName="IMG-20210304-WA0007.jpg", NewsId = 9},
                new Gallery() {GalleryId = 9, GalleryFileName="IMG-20210304-WA0008.jpg", NewsId = 9},
                new Gallery() {GalleryId = 9, GalleryFileName="IMG-20210304-WA0002.jpg", NewsId = 9}
            };

            gallery.ForEach(g => context.DbGallery.Add(g));
            context.SaveChanges();
        }
    }
}