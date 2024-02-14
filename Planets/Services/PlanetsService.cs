using TARpe22MauiPlanets.Models;


namespace TARpe22MauiPlanets.Services
{
    internal static class PlanetsService
    {
        private static List<Planet> planets = new()
        {
            new()
            {
                Name = "Mercury",
                Subtitle="The smallest planet",
                HeroImage="mercury.png",
                Description="Mercury—the smallest planet in our solar system and nearest to the Sun—is only slightly larger than Earth's Moon. Its surface is covered in tens of thousands of impact craters.\r\n\r\nFrom the surface of Mercury, the Sun would appear more than three times as large as it does when viewed from Earth, and the sunlight would be as much as 11 times brighter.\r\n\r\nDespite its proximity to the Sun, Mercury is not the hottest planet in our solar system— that title belongs to nearby Venus, thanks to its dense atmosphere. But Mercury is the fastest planet, zipping around the Sun every 88 Earth days. Mercury is appropriately named for the swiftest of the ancient Roman gods.",
                AccentColorStart = Color.FromArgb("#353535"),
                AccentColorEnd = Color.FromArgb("#8d9098"),
                Images = new()
                {
                    "https://cdn.theatlantic.com/thumbor/D15rQggf6357X1-u6VpTD2N1yQE=/0x27:1041x613/976x549/media/img/mt/2017/04/MercuryImage/original.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/73_carousel_mercury_2.jpg",
                    "https://science.nasa.gov/_ipx/w_2048&f_webp/https://smd-cms.nasa.gov/wp-content/uploads/2023/05/pia19422-mercury.jpg"
                }
            },

            new()
            {
                Name = "Venus",
                Subtitle="Venus is the second planet from the Sun, and the sixth largest planet. It’s the hottest planet in our solar system.",
                HeroImage="venus.png",
                Description="Venus is a cloud-swaddled planet named for a love goddess, and often called Earth’s twin. But pull up a bit closer, and Venus turns hellish. Our nearest planetary neighbor, the second planet from the Sun, has a surface hot enough to melt lead. The atmosphere is so thick that, from the surface, the Sun is just a smear of light.\r\n\r\nIn some ways it is more an opposite of Earth than a twin: Venus spins backward, has a day longer than its year, and lacks any semblance of seasons. It might once have been a habitable ocean world, like Earth, but that was at least a billion years ago. A runaway greenhouse effect turned all surface water into vapor, which then leaked slowly into space. The present-day surface of volcanic rock is blasted by high temperatures and pressures. Asked if the surface of Venus is likely to be life-bearing today, we can give a quick answer: a hard “no.”\r\n\r\nFurther, Venus may hold lessons about what it takes for life to get its start ­– on Earth, in our solar system, or across the galaxy. The ingredients are all there, or at least, they used to be. By studying why our neighbor world went in such a different direction with regard to habitability, we could find out what could make other worlds right. And while it might sound absurd, we can’t rule out life on Venus entirely. Temperature, air pressure, and chemistry are much more congenial up high, in those thick, yellow clouds.",
                AccentColorStart = Color.FromArgb("#a6393b"),
                AccentColorEnd = Color.FromArgb("#d17f21"),
                Images = new()
                {
                    "https://solarsystem.nasa.gov/system/feature_items/images/143_Venus-800x600.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/147_Hubble_Venus_Clouds-800x600.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/146_venus_carousel_3.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/144_PIA00485_Venus_Caldera-800.jpg"
                }
            },
            new()
            {
                Name = "Earth",
                Subtitle="Your home. Our Mission.\r\nAnd the one planet that NASA studies more than any other.",
                HeroImage="earth.png",
                Description="Earth is the third planet from the Sun and the only astronomical object known to harbor life. This is enabled by Earth being a water world, the only one in the Solar System sustaining liquid surface water. Almost all of Earth's water is contained in its global ocean, covering 70.8% of Earth's crust. The remaining 29.2% of Earth's crust is land, most of which is located in the form of continental landmasses within one hemisphere, Earth's land hemisphere. Most of Earth's land is somewhat humid and covered by vegetation, while large sheets of ice at Earth's polar deserts retain more water than Earth's groundwater, lakes, rivers and atmospheric water combined. Earth's crust consists of slowly moving tectonic plates, which interact to produce mountain ranges, volcanoes, and earthquakes. Earth has a liquid outer core that generates a magnetosphere capable of deflecting most of the destructive solar winds and cosmic radiation. ",
                AccentColorStart = Color.FromArgb("#0e3d68"),
                AccentColorEnd = Color.FromArgb("#2e97c7"),
                Images = new()
                {
                    "https://solarsystem.nasa.gov/system/feature_items/images/68_epicearthmoonstill_800.png",
                    "https://solarsystem.nasa.gov/system/feature_items/images/69_earth_carousel_3.jpg",
                    "https://images.newscientist.com/wp-content/uploads/2019/09/09162708/iss048-e-2035_lrg.jpg?width=778"
                }
            },
            new()
            {
                Name = "Mars",
                Subtitle="Mars is the fourth planet from the Sun, and the seventh largest. It’s the only planet we know of inhabited entirely by robots.",
                HeroImage="mars.png",
                Description="Mars is no place for the faint-hearted. It’s dry, rocky, and bitter cold. The fourth planet from the Sun, Mars is one of Earth's two closest planetary neighbors (Venus is the other). Mars is one of the easiest planets to spot in the night sky – it looks like a bright red point of light.\r\n\r\nDespite being inhospitable to humans, robotic explorers – like NASA's Perseverance rover – are serving as pathfinders to eventually get humans to the surface of the Red Planet.",
                AccentColorStart = Color.FromArgb("#a23036"),
                AccentColorEnd = Color.FromArgb("#eb3333"),
                Images = new()
                {
                    "https://researchfdi.com/wp-content/uploads/2021/10/8944_1-PIA24546-1280.jpeg",
                    "https://www.worldatlas.com/r/w1300-q80/upload/bb/c3/32/shutterstock-1041249343.jpg",
                    "https://www.openaccessgovernment.org/wp-content/uploads/2021/04/dreamstime_xxl_121672573-scaled.jpg"
                }
            },
            new()
            {
                Name = "Jupiter",
                Subtitle="Jupiter is the fifth planet from the Sun, and the largest in the solar system – more than twice as massive as the other planets combined.",
                HeroImage="jupiter.png",
                Description="Jupiter is the fifth planet from our Sun and is, by far, the largest planet in the solar system – more than twice as massive as all the other planets combined.\r\n\r\nJupiter's stripes and swirls are actually cold, windy clouds of ammonia and water, floating in an atmosphere of hydrogen and helium. Jupiter’s iconic Great Red Spot is a giant storm bigger than Earth that has raged for hundreds of years.\r\n\r\nJupiter is named for the king of the ancient Roman gods.​",
                AccentColorStart = Color.FromArgb("#9d4a40"),
                AccentColorEnd = Color.FromArgb("#cd8026"),
                Images = new()
                {
                    "https://solarsystem.nasa.gov/system/feature_items/images/11_Full_Jupiter-800.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/10_Jupiter_Io_Juno-800.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/13_PIA24237_Jupiter_Cyclones-800.jpg"
                }
            },
            new()
            {
                Name = "Saturn",
                Subtitle="Saturn is the sixth planet from the Sun, and the second largest in the solar system. It’s surrounded by beautiful rings.",
                HeroImage="saturn.png",
                Description="Saturn is the sixth planet from the Sun and the second largest planet in our solar system. Adorned with a dazzling system of icy rings, Saturn is unique among the planets.\r\n\r\nIt is not the only planet to have rings, but none are as spectacular or as complex as Saturn's. Like fellow gas giant Jupiter, Saturn is a massive ball made mostly of hydrogen and helium.\r\n\r\nThe farthest planet from Earth discovered by the unaided human eye, Saturn has been known since ancient times. The planet is named for the Roman god of agriculture and wealth, who was also the father of Jupiter.",
                AccentColorStart = Color.FromArgb("#996237"),
                AccentColorEnd = Color.FromArgb("#c6502f"),
                Images = new()
                {
                    "https://solarsystem.nasa.gov/system/feature_items/images/151_saturn_carousel_1.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/152_saturn_carousel_2.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/155_saturn_carousel_5.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/153_saturn_carousel_3.jpg"
                }
            },

            new()
            {
                Name = "Uranus",
                Subtitle="Uranus is the seventh planet from the Sun, and the third largest planet in our solar system. It appears to spin sideways.",
                HeroImage="uranus.png",
                Description="Uranus is the seventh planet from the Sun, and it's the third largest planet in our solar system – about four times wider than Earth. The diameter at its equator is 31,763 miles (51,120 kilometers).\r\n\r\nUranus is a very cold and windy planet. It is surrounded by faint rings, and more than two dozen small moons as it rotates at a nearly 90-degree angle from the plane of its orbit. This unique tilt makes Uranus appear to spin on its side.\r\n\r\nUranus is blue-green in color due to large amounts of methane, which absorbs red light but allows blues to be reflected back into space. The atmosphere is mostly hydrogen and helium, but also includes large amounts of water, ammonia and methane.\r\n\r\nAstronomer William Herschel tried unsuccessfully to name his discovery Georgium Sidus (George's star in Latin) after his patron, England's King George III. Instead, the planet was eventually named for Uranus, the Greek god of the sky, who was also the father of Kronos (or Saturn in Roman mythology).\r\n\r\nOnly one spacecraft has explored the ice giant up close, NASA's Voyager 2. In January 1986, Voyager 2 made a close approach to Uranus, snapping images of the planet and some its moons. A new mission to Uranus was one of the highest priority objectives outlined in the Planetary Science and Astrobiology Decadal Survey 2023-2032\r\n. The possibility of a flagship mission to Uranus will be a focus of planetary science at NASA in the years to come.",
                AccentColorStart = Color.FromArgb("#9d4a40"),
                AccentColorEnd = Color.FromArgb("#996237"),
                Images = new()
                {
                    "https://solarsystem.nasa.gov/system/feature_items/images/88_carousel_uranus.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/89_uranus_carousel_1.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/88_carousel_uranus.jpg"
                }
            },
            new()
            {
                Name = "Neptune",
                Subtitle="Neptune is the eighth, and most distant planet from the Sun. It’s the fourth-largest, and the first planet discovered with math.",
                HeroImage="neptune.png",
                Description="Dark, cold and whipped by supersonic winds, giant Neptune is the eighth and most distant major planet orbiting our Sun. More than 30 times as far from the Sun as Earth, Neptune is not visible to the naked eye. In 2011, Neptune completed its first 165-year orbit since its discovery.\r\n\r\nThe planet’s rich blue color comes from methane in its atmosphere, which absorbs red wavelengths of light, but allows blue ones to be reflected back into space.\r\n\r\nNeptune was the first planet located through mathematical calculations. Using predictions sent to him by French astronomer Urbain Le Verrier, based on disturbances in the orbit of Uranus, German astronomer Johann Galle was the first to observe the planet in 1846. The planet is named after the Roman god of the sea, as suggested by Le Verrier.",
                AccentColorStart = Color.FromArgb("#0c293d"),
                AccentColorEnd = Color.FromArgb("#26abe0"),                Images = new()
                {
                    "https://solarsystem.nasa.gov/system/feature_items/images/82_carousel_neptune_1.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/86_carousel_neptune_5.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/84_neptune_carousel_2.jpg"
                }
            },
            new()
            {
                Name = "Pluto",
                Subtitle="Pluto was once our solar system's ninth planet, but has been reclassified as a dwarf planet. It's located in the Kuiper Belt.",
                HeroImage="pluto.png",
                Description="Pluto is a dwarf planet located in a distant region of our solar system beyond Neptune known as the Kuiper Belt. Pluto was long considered our ninth planet, but the International Astronomical Union reclassified Pluto\r\n\r\nas a dwarf planet in 2006.\r\n\r\nNASA's New Horizons was the first spacecraft to explore Pluto up close, flying by the dwarf planet and its moons in 2015. It found that Pluto is a complex world with mountains, valleys, plains, craters, and apparently even glaciers.\r\n\r\nPluto was discovered in 1930 by astronomer Clyde Tombaugh at the Lowell Observatory in Flagstaff, Arizona. It was named by 11-year-old Venetia Burney of Oxford, England.",
                AccentColorStart = Color.FromArgb("#0c293d"),
                AccentColorEnd = Color.FromArgb("#26abe0"),                
                Images = new()
                {
                   "",
                   "",
                   ""
                }
            },
            new()
            {
                Name = "Ceres",
                Subtitle="Dwarf planet Ceres is the largest object in the asteroid belt between Mars and Jupiter. It was explored by NASA's Dawn spacecraft.",
                HeroImage="ceres.png",
                Description="Dwarf planet Ceres is the largest object in the asteroid belt between Mars and Jupiter, and it's the only dwarf planet located in the inner solar system. It was the first member of the asteroid belt to be discovered when Giuseppe Piazzi spotted it in 1801. When NASA's Dawn arrived in 2015, Ceres became the first dwarf planet to be explored by a spacecraft.\r\n\r\nCalled an asteroid for many years, Ceres is so much bigger and so different from its rocky neighbors that scientists classified it as a dwarf planet in 2006. Even though Ceres comprises 25% of the asteroid belt's total mass, Pluto is still 14 times more massive.\r\n\r\nCeres is named for the Roman goddess of corn and harvests. The word cereal comes from the same name.",
                AccentColorStart = Color.FromArgb("#0c293d"),
                AccentColorEnd = Color.FromArgb("#26abe0"),                
                Images = new()
                {
                   "",
                   "",
                   ""
                }
            },
            new()
            {
                Name = "Haumea",
                Subtitle="Dwarf planet Haumea was originally designated 2003 EL61 (and nicknamed Santa by one discovery team). Haumea is located in the Kuiper Belt, a doughnut-shaped region of icy bodies beyond the orbit of Neptune. ",
                HeroImage="haumea.png",
                Description="Haumea is an oval-shaped dwarf planet that is roughly the same size as Pluto. It is one of the fastest rotating large objects in our solar system. The fast spin distorts Haumea's shape, making this dwarf planet look like a football. Everything we know about Haumea is from observations with ground-based telescopes from around the world.\\r\\n\\r\\nTwo teams claim credit for discovering Haumea citing evidence from observations made in 2003 and 2004. The International Astronomical Union’s Gazetteer of Planetary Nomenclature lists the discovery location as Sierra Nevada Observatory in Spain on Mar. 7, 2003, but no official discoverer is listed",
                AccentColorStart = Color.FromArgb("#0c293d"),
                AccentColorEnd = Color.FromArgb("#26abe0"),                
                Images = new()
                {
                   "",
                   "",
                   ""
                }
            },
            new()
            {
                Name = "Makemake",
                Subtitle="Makemake was named after the Rapanui god of fertility.",
                HeroImage="makemake.png",
                Description="Dwarf planet Makemake – along with Pluto, Haumea, and Eris – is located in the Kuiper Belt, a donut-shaped region of icy bodies beyond the orbit of Neptune. Makemake is slightly smaller than Pluto, and is the second-brightest object in the Kuiper Belt as seen from Earth while Pluto is the brightest. It takes about 305 Earth years for this dwarf planet to make one trip around the Sun.\r\n\r\nMakemake holds an important place in the history of solar system studies because it was one of the objects – along with Eris – whose discovery prompted the International Astronomical Union to reconsider the definition of a planet, and to create the new group of dwarf planets.\r\n\r\nMakemake was first observed in March 2005 by M.E. Brown, C.A. Trujillo, and D.L. Rabinowitz at the Palomar Observatory, California. Its unofficial codename was Easterbunny, Brown said, \"in honor of the fact that it was discovered just a few days past Easter.\" Before this dwarf planet was confirmed, its provisional name was 2005 FY9. In 2016, NASA’s Hubble Space Telescope spotted a small, dark moon orbiting Makemake.",
                AccentColorStart = Color.FromArgb("#0c293d"),
                AccentColorEnd = Color.FromArgb("#26abe0"),                
                Images = new()
                {
                   "",
                   "",
                   ""
                }
            },
            new()
            {
                Name = "Eris",
                Subtitle="Eris is one of the largest known dwarf planets in our solar system. It's about the same size as Pluto but is three times farther from the Sun.",
                HeroImage="eris.png",
                Description="The discovery of Eris help trigger a debate in the scientific community that led to the International Astronomical Union's decision in 2006 to clarify the definition of a planet. Pluto, Eris, and other similar objects are now classified as dwarf planets.\r\n\r\nEris was discovered on Jan. 5, 2005, from data obtained on Oct. 21, 2003, during a Palomar Observatory survey of the outer solar system by Mike Brown, a professor of planetary astronomy at the California Institute of Technology; Chad Trujillo of the Gemini Observatory; and David Rabinowitz of Yale University.",
                AccentColorStart = Color.FromArgb("#0c293d"),
                AccentColorEnd = Color.FromArgb("#26abe0"),                
                Images = new()
                {
                   "",
                   "",
                   ""
                }
            },

        };

        public static List<Planet> GetFeaturedPlanets()
        {
            var random = new Random();
            var randomizedPlanets = planets.OrderBy(item => random.Next());

            return randomizedPlanets.Take(2).ToList();
        }

        public static List<Planet> GetAllPlanets()
            => planets;
    }
}