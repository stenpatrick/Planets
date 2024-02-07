using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

                }
            },
            
            new()
            {
                Name = "Venus",
                Subtitle="Venus is the second planet from the Sun, and the sixth largest planet. It’s the hottest planet in our solar system.",
                HeroImage="venus.png",
                Description="Venus is a cloud-swaddled planet named for a love goddess, and often called Earth’s twin. But pull up a bit closer, and Venus turns hellish. Our nearest planetary neighbor, the second planet from the Sun, has a surface hot enough to melt lead. The atmosphere is so thick that, from the surface, the Sun is just a smear of light.\r\n\r\nIn some ways it is more an opposite of Earth than a twin: Venus spins backward, has a day longer than its year, and lacks any semblance of seasons. It might once have been a habitable ocean world, like Earth, but that was at least a billion years ago. A runaway greenhouse effect turned all surface water into vapor, which then leaked slowly into space. The present-day surface of volcanic rock is blasted by high temperatures and pressures. Asked if the surface of Venus is likely to be life-bearing today, we can give a quick answer: a hard “no.”\r\n\r\nFurther, Venus may hold lessons about what it takes for life to get its start ­– on Earth, in our solar system, or across the galaxy. The ingredients are all there, or at least, they used to be. By studying why our neighbor world went in such a different direction with regard to habitability, we could find out what could make other worlds right. And while it might sound absurd, we can’t rule out life on Venus entirely. Temperature, air pressure, and chemistry are much more congenial up high, in those thick, yellow clouds.",
                AccentColorStart = Color.FromArgb("#353535"),
                AccentColorEnd = Color.FromArgb("#8d9098"),
                Images = new()
            },
            new()
            {
                Name = "Earth",
                Subtitle="Your home. Our Mission.\r\nAnd the one planet that NASA studies more than any other.",
                HeroImage="earth.png",
                Description="Earth is the third planet from the Sun and the only astronomical object known to harbor life. This is enabled by Earth being a water world, the only one in the Solar System sustaining liquid surface water. Almost all of Earth's water is contained in its global ocean, covering 70.8% of Earth's crust. The remaining 29.2% of Earth's crust is land, most of which is located in the form of continental landmasses within one hemisphere, Earth's land hemisphere. Most of Earth's land is somewhat humid and covered by vegetation, while large sheets of ice at Earth's polar deserts retain more water than Earth's groundwater, lakes, rivers and atmospheric water combined. Earth's crust consists of slowly moving tectonic plates, which interact to produce mountain ranges, volcanoes, and earthquakes. Earth has a liquid outer core that generates a magnetosphere capable of deflecting most of the destructive solar winds and cosmic radiation. ",
                AccentColorStart = Color.FromArgb("#353535"),
                AccentColorEnd = Color.FromArgb("#8d9098"),
                Images = new()
                {

                }
            },
            new()
            {
                Name = "Mars",
                Subtitle="Mars is the fourth planet from the Sun, and the seventh largest. It’s the only planet we know of inhabited entirely by robots.",
                HeroImage="mars.png",
                Description="Mars is no place for the faint-hearted. It’s dry, rocky, and bitter cold. The fourth planet from the Sun, Mars is one of Earth's two closest planetary neighbors (Venus is the other). Mars is one of the easiest planets to spot in the night sky – it looks like a bright red point of light.\r\n\r\nDespite being inhospitable to humans, robotic explorers – like NASA's Perseverance rover – are serving as pathfinders to eventually get humans to the surface of the Red Planet.",
                AccentColorStart = Color.FromArgb("#353535"),
                AccentColorEnd = Color.FromArgb("#8d9098"),
                Images = new()
                {

                }
            },
            new()
            {
                Name = "Jupiter",
                Subtitle="Jupiter is the fifth planet from the Sun, and the largest in the solar system – more than twice as massive as the other planets combined.",
                HeroImage="jupiter.png",
                Description="Jupiter is the fifth planet from our Sun and is, by far, the largest planet in the solar system – more than twice as massive as all the other planets combined.\r\n\r\nJupiter's stripes and swirls are actually cold, windy clouds of ammonia and water, floating in an atmosphere of hydrogen and helium. Jupiter’s iconic Great Red Spot is a giant storm bigger than Earth that has raged for hundreds of years.\r\n\r\nJupiter is named for the king of the ancient Roman gods.​",
                AccentColorStart = Color.FromArgb("#353535"),
                AccentColorEnd = Color.FromArgb("#8d9098"),
                Images = new()
                {

                }
            },
            new()
            {
                Name = "Saturn",
                Subtitle="Saturn is the sixth planet from the Sun, and the second largest in the solar system. It’s surrounded by beautiful rings.",
                HeroImage="saturn.png",
                Description="Saturn is the sixth planet from the Sun and the second largest planet in our solar system. Adorned with a dazzling system of icy rings, Saturn is unique among the planets.\r\n\r\nIt is not the only planet to have rings, but none are as spectacular or as complex as Saturn's. Like fellow gas giant Jupiter, Saturn is a massive ball made mostly of hydrogen and helium.\r\n\r\nThe farthest planet from Earth discovered by the unaided human eye, Saturn has been known since ancient times. The planet is named for the Roman god of agriculture and wealth, who was also the father of Jupiter.",
                AccentColorStart = Color.FromArgb("#353535"),
                AccentColorEnd = Color.FromArgb("#8d9098"),
                Images = new()
                {

                }
            },

            new()
            {
                Name = "Uranus",
                Subtitle="Uranus is the seventh planet from the Sun, and the third largest planet in our solar system. It appears to spin sideways.",
                HeroImage="uranus.png",
                Description="Uranus is the seventh planet from the Sun, and it's the third largest planet in our solar system – about four times wider than Earth. The diameter at its equator is 31,763 miles (51,120 kilometers).\r\n\r\nUranus is a very cold and windy planet. It is surrounded by faint rings, and more than two dozen small moons as it rotates at a nearly 90-degree angle from the plane of its orbit. This unique tilt makes Uranus appear to spin on its side.\r\n\r\nUranus is blue-green in color due to large amounts of methane, which absorbs red light but allows blues to be reflected back into space. The atmosphere is mostly hydrogen and helium, but also includes large amounts of water, ammonia and methane.\r\n\r\nAstronomer William Herschel tried unsuccessfully to name his discovery Georgium Sidus (George's star in Latin) after his patron, England's King George III. Instead, the planet was eventually named for Uranus, the Greek god of the sky, who was also the father of Kronos (or Saturn in Roman mythology).\r\n\r\nOnly one spacecraft has explored the ice giant up close, NASA's Voyager 2. In January 1986, Voyager 2 made a close approach to Uranus, snapping images of the planet and some its moons. A new mission to Uranus was one of the highest priority objectives outlined in the Planetary Science and Astrobiology Decadal Survey 2023-2032\r\n. The possibility of a flagship mission to Uranus will be a focus of planetary science at NASA in the years to come.",
                AccentColorStart = Color.FromArgb("#353535"),
                AccentColorEnd = Color.FromArgb("#8d9098"),
                Images = new()
                {

                }
            },
            new()
            {
                Name = "Neptune",
                Subtitle="Neptune is the eighth, and most distant planet from the Sun. It’s the fourth-largest, and the first planet discovered with math.",
                HeroImage="neptune.png",
                Description="Dark, cold and whipped by supersonic winds, giant Neptune is the eighth and most distant major planet orbiting our Sun. More than 30 times as far from the Sun as Earth, Neptune is not visible to the naked eye. In 2011, Neptune completed its first 165-year orbit since its discovery.\r\n\r\nThe planet’s rich blue color comes from methane in its atmosphere, which absorbs red wavelengths of light, but allows blue ones to be reflected back into space.\r\n\r\nNeptune was the first planet located through mathematical calculations. Using predictions sent to him by French astronomer Urbain Le Verrier, based on disturbances in the orbit of Uranus, German astronomer Johann Galle was the first to observe the planet in 1846. The planet is named after the Roman god of the sea, as suggested by Le Verrier.",
                AccentColorStart = Color.FromArgb("#353535"),
                AccentColorEnd = Color.FromArgb("#8d9098"),
                Images = new()
                {

                }
            },
        };
    }
}
