﻿namespace tp2JordanCoutureLafranchise.Models
{
    public class BaseDeDonnees
    {
        public List<Parent> Parents;

        public List<Enfant> Enfants;


        public BaseDeDonnees()
        {
            Parents = new List<Parent>()
            {
                new Parent() {ParentId=1, Nom="Penguins de Pittsburgh",  Description="Équipe de hockey sur glace de la LNH basée à Pittsburgh", ImageURL="/Images/pittsburgh.png"},
                new Parent() {ParentId=2, Nom="Canadiens de Montréal", Description="Équipe de hockey sur glace de la LNH basée à Montréal", ImageURL="/Images/Mon_projet_1.png"},
                new Parent() {ParentId=3, Nom="Capitals de Washington",  Description="Équipe de hockey sur glace de la LNH basée à Washington", ImageURL="/Images/capitals.png"}
            };

            Enfants = new List<Enfant>()
            {
                    new Enfant() {Id=1, ParentId=2, ImageURL="/Images/niskcsuzuki-removebg-preview.png", Nom="Nick Suzuki",
                    Description="Nick Suzuki est un joueur de hockey canadien talentueux. Il est connu pour sa vision du jeu," +
                    " ses habiletés de patinage et sa précision de tir. Suzuki est un atout précieux pour son équipe, apportant constamment" +
                    " une énergie et une créativité exceptionnelles sur la glace.", NumeroDeChandail=14,
                    Age="23 ans", Position="C", Salaire=8, Equipe="Canadiens de Montréal", EnVedette="Oui"},

                   new Enfant() {Id=2, ParentId=2, ImageURL="/Images/8481540_3x-removebg-preview.png", Nom="Cole Caufield",
                    Description="Cole Caufield est une étoile montante du hockey américain. Malgré sa petite stature," +
                    " il possède un tir redoutable et une grande agilité. Son instinct de buteur et sa vitesse font de lui un joueur à surveiller de près.",
                       NumeroDeChandail=22,
                    Age="22 ans", Position="AD", Salaire=5, Equipe="Canadiens de Montréal", EnVedette="Oui"},

                    new Enfant() {Id=3, ParentId=2, ImageURL="/Images/8474596_3x-removebg-preview.png", Nom="Jake Allen",
                    Description="Jake Allen est un gardien de but canadien fiable et expérimenté. Son calme et sa position solide font de lui un dernier rempart redoutable. " +
                    "Il excelle dans les arrêts difficiles et inspire confiance à son équipe.",
                       NumeroDeChandail=34,
                    Age="32 ans", Position="G", Salaire=4, Equipe="Canadiens de Montréal", EnVedette="Non"},

                    new Enfant() {Id=4, ParentId=2, ImageURL="/Images/8476469_3x-removebg-preview.png", Nom="Joel Armia",
                    Description="Joel Armia est un joueur de hockey finlandais polyvalent. Sa taille imposante et sa force lui confèrent un avantage physique. Il est habile dans les situations défensives " +
                    "et peut contribuer offensivement avec sa précision de tir.",
                       NumeroDeChandail=40, Age="30 ans", Position="AD", Salaire=2, Equipe="Canadiens de Montréal", EnVedette="Oui"},

                    new Enfant() {Id=5, ParentId=3, ImageURL="/Images/8471698_3x-removebg-preview.png", Nom="T.J. Oshie",
                    Description="TJ Oshie est un attaquant américain talentueux et charismatique. Son patinage rapide, son habileté au niveau des passes et son jeu physique font de lui un joueur complet et apprécié" +
                    " de ses coéquipiers et des partisans.",
                       NumeroDeChandail=77, Age="36 ans", Position="AD", Salaire=5, Equipe="Capitals de Washington", EnVedette="Non"},

                    new Enfant() {Id=6, ParentId=3, ImageURL="/Images/8475625_3x-removebg-preview.png", Nom="Matt Irwin",
                    Description="Matt Irwin est un défenseur de hockey canadien fiable et solide. Il excelle dans la lecture du jeu et le positionnement défensif. Son tir puissant et précis lui permet de contribuer" +
                    " offensivement de temps en temps.",
                       NumeroDeChandail=52, Age="35 ans", Position="D", Salaire=1, Equipe="Capitals de Washington", EnVedette="Non"},

                    new Enfant() {Id=7, ParentId=3, ImageURL="/Images/8471214_3x__1_-removebg-preview.png", Nom="Alex Ovechkin",
                    Description="Alex Ovechkin, surnommé Ovi, est une légende russe du hockey sur glace. Puissant et talentueux, il est considéré comme l'un des meilleurs buteurs de tous les temps. Son style de jeu spectaculaire" +
                    " et sa détermination ont captivé les fans du monde entier.",
                    NumeroDeChandail=8, Age="37 ans", Position="AG", Salaire=9, Equipe="Capitals de Washington", EnVedette="Non"},

                    new Enfant() {Id=8, ParentId=3, ImageURL="/Images/8475324_3x-removebg-preview_1.png", Nom="Nick Jensen",
                    Description="Nick Jensen est un défenseur de hockey américain intelligent et discipliné. Il possède de bonnes aptitudes défensives et est efficace dans les transitions de jeu. Son jeu calme et fiable " +
                    "fait de lui un atout précieux pour son équipe.",
                    NumeroDeChandail=3, Age="32 ans", Position="D", Salaire=3, Equipe="Capitals de Washington", EnVedette="Non"},

                    new Enfant() {Id=9, ParentId=1, ImageURL="/Images/8473507_3x-removebg-preview.png", Nom="Jeff Petry",
                    Description="Jeff Petry est un défenseur de hockey américain de premier plan. Il est reconnu pour sa mobilité, son jeu physique et son habileté à générer des points. Un défenseur" +
                    " polyvalent et fiable.",
                    NumeroDeChandail=26, Age="35 ans", Position="D", Salaire=4, Equipe="Penguins de Pittsburgh", EnVedette="Oui"},

                    new Enfant() {Id=10, ParentId=1, ImageURL="/Images/8480172_3x-removebg-preview.png", Nom="Jan Rutta",
                    Description="Jan Rutta est un défenseur tchèque talentueux. Sa grande taille et sa force physique lui permettent d'être un excellent défenseur défensif. Il possède également une bonne vision" +
                    " du jeu et contribue offensivement avec son tir précis.",
                    NumeroDeChandail=44, Age="32 ans", Position="D", Salaire=3, Equipe="Penguins de Pittsburgh", EnVedette="Oui"},

                    new Enfant() {Id=11, ParentId=1, ImageURL="/Images/ç-removebg-preview.png", Nom="Bryan Rust",
                    Description="Bryan Rust est un attaquant polyvalent et dynamique. Sa vitesse, son tir précis et sa détermination en font un joueur redoutable en attaque. Il est également solide en jeu défensif et " +
                    "contribue régulièrement aux succès de son équipe",
                    NumeroDeChandail=17, Age="31 ans", Position="AD", Salaire=6, Equipe="Penguins de Pittsburgh", EnVedette="Oui"},

                     new Enfant() {Id=12, ParentId=1, ImageURL="/Images/8470604_3x-removebg-preview.png", Nom="Jeff Carter",
                    Description="Jeff Carter est un vétéran du hockey canadien. Son expérience et son talent en font un attaquant redoutable." +
                    " Son tir puissant et sa présence physique lui permettent de marquer des buts importants.",
                    NumeroDeChandail=77, Age="38 ans", Position="C", Salaire=3, Equipe="Penguins de Pittsburgh", EnVedette="Oui"}
            };


            ////lier les objets enfants aux differents parents
            //foreach (var p in Parents)
            //{
            //    p.Enfants = new List<Enfant>();
            //    p.Enfants.AddRange(Enfants.Where(e => e.ParentId == p.Id));
            //}

            ////lier les objets parents aux differents enfants

            //foreach (var e in Enfants)
            //{
            //    e.Parent = Parents.Where(p => p.Id == e.IdParent).Single();
            //}


        }
    }
}
