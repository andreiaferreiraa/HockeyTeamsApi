namespace HockeyTeamAPI.Migrations
{
    using HockeyTeamAPI.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<HockeyTeamAPI.Models.HockeyDB>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(HockeyTeamAPI.Models.HockeyDB context)
        {
            //*****************************************************************************************************************
            // adiciona Equipas
            var equipas = new List<Equipas> {
               new Equipas {ID=1, Nome="SL. BENFICA", NomeTodo="Sport Lisboa e Benfica", DataFundacao = new DateTime(1904,02,28), Pais = "Portugal", Cidade="Lisboa", Presidente="Lu�s Filipe Vieira", EpocaCampeonatoPortugues="1950/51, 1951/52, 1955/56, 1956/57, 1959/60, 1960/61, 1965/66, 1966/67, 1967/68, 1969/70, 1971/72, 1973/74, 1978/79, 1979/80, 1980/81, 1991/92, 1993/94, 1994/95, 1996/97, 1997/98, 2011/12, 2014/15, 2015/16", EpocaCampeonatoMetropolitano="1967, 1968, 1970, 1972, 1973, 1974", EpocaTacaPortugal="1962/63, 1977/78, 1978/79, 1979/80, 1980/81, 1981/82, 1990/91, 1993/94, 1994/95, 1999/00, 2000/01, 2001/02, 2009/10, 2013/14, 2014/2015", EpocaSupertacaAntonioLivramento="1993, 1995, 1997, 2001, 2002, 2010, 2012", Historia="H�quei Patins � uma das modalidades mais antigas do Clube, sendo a equipa que a pratica h� mais tempo a n�vel mundial. " +
               "A equipa principal do Benfica joga na primeira divis�o da modalidade , sendo o clube com mais Campeonatos Nacionais e Campeonatos Metropolitanos ganhos. " +
               "Alguns dos seus jogadores s�o chamados para representar a Sele��o Nacional, comoJo�o Rodrigues, Diogo Rafael e Pedro Henriques.", Logotipo="Benfica.jpg", },
               new Equipas {ID=2, Nome="SPORTING", NomeTodo="Sporting Clube de Portugal", DataFundacao= new DateTime(1906,07,01), Pais="Portugal", Cidade="Lisboa", Presidente="Bruno de Carvalho", EpocaCampeonatoPortugues="1938/39, 1974/75, 1975/76, 1976/77, 1977/78, 1981/82, 1987/88, 2017/18", EpocaCampeonatoMetropolitano="", EpocaTacaPortugal="1976/77, 1977/78, 1983/84, 1989/90", EpocaSupertacaAntonioLivramento="1983, 2015", Historia="H�quei patins � praticado pelo Sporting  desde 1924. Foi uma das melhores equipas do mundo entre os finais dos anos 1970 e in�cio dos anos 1980. " +
               "Em 2005, a modalidade foi extinguida, tendo sido retomada em 2010, subindo � primeira divis�o na �poca de 2011/2012, 2 anos ap�s a subida. Nesta �ltima �poca 2017/2018, sagrou-se campe� Nacional, feito que j� n�o acontecia � 30 anos. O guarda-redes �ngelo Gir�o � chamado para representar a Sele��o Nacional.", Logotipo="Sporting.jpg"},
               new Equipas {ID=3, Nome="FC PORTO", NomeTodo="Futebol Clube do Porto", DataFundacao=new DateTime(1983,09,28), Pais="Portugal", Cidade="Porto", Presidente="Pinto da Costa", EpocaCampeonatoPortugues="1982/83, 1983/84, 1984/85, 1985/86, 1986/87, 1988/89, 1989/90, 1990/91, 1998/99, 1999/00, 2001/02, 2002/03, 2003/04, 2004/05, 2005/06, 2006/07, 2007/08, 2008/09, 2009/10, 2010/11, 2012/13, 2016/17", EpocaCampeonatoMetropolitano="1968/69", EpocaTacaPortugal="1982/83, 1984/85, 1985/86, 1986/87, 1988/89, 1995/96, 1997/98, 1998/99, 2004/05, 2005/06, 2007/08, 2008/09, 2012/13, 2015/16, 2016/17, 2017/18", EpocaSupertacaAntonioLivramento="1984, 1985, 1986, 1987, 1988, 1989, 1990, 1991, 1992, 1996, 1998, 1999, 2005, 2006, 2007, 2008, 2009, 2011, 2013, 2016, 2017", Historia="O H�quei em Patins � uma das modalidades mais prestigiadas do Futebol Clube do Porto, sendo a segunda equipa nacional com mais campeonatos nacionais ganhos. Foi por onde passou como seccionista o atual presidentedo clube, Pinto da Costa. A pr�tica desta modalidade foi iniciada em 1954, devido � vontade de muita gente como dirigentes e adeptos do clube,vontade essa motivada pelas excelentes presta��es  da sele��o nacional. Os jogadores H�lder Nunes, Rafael Costa e Gon�alo Alves, s�o chamados � Sele��o Nacional.", Logotipo="Porto.jpg"},
               new Equipas {ID=4, Nome="UD OLIVEIRENSE", NomeTodo="Uni�o Desportiva Oliveirense", DataFundacao=new DateTime(1922,10,25), Pais="Portugal", Cidade="Oliveira de Azem�is", Presidente="Hor�cio Bastos", EpocaCampeonatoPortugues="1986�87, 1996/97, 2003/04,2006/07, 2009/10, 2010/11, 2012/13", EpocaCampeonatoMetropolitano="", EpocaTacaPortugal="1996/97, 2010/11, 2011/12", EpocaSupertacaAntonioLivramento="", Historia="Ter� sido em 1969 que se iniciou a cria��o da equipa de h�quei em patins  em Oliveira de Azem�is. A partir de janeiro de 1970, e por indica��o da Federa��o Portugues de Patinagem, o Oliveirense passa a fazer parte da Associa��o de Patinagem de Aveiro.No entanto, nesta �poca o campeonato regional em Aveiro n�o se realizaria e a UD Oliveirense acabaria por disputar o Campeonato Regional do Porto, prova que servia de apuramento para a 2� Divis�o Nacional, sagrando-se campe�. Atualmente � considerada o '3� Grande' no H�quei em Patins em Portugal, em conjunto com o FC Porto e o SL Benfica. Ricardo Barreiros foi um jogador do Oliveirense que j� representou a Sele��o Nacional, tal como Jo�o Souto.", Logotipo="Oliveirense.jpg"},
               new Equipas {ID=5, Nome="Sp. TOMAR", NomeTodo="Sporting Clube de Tomar", DataFundacao=new DateTime(1915,02,26), Pais="Portugal", Cidade="Tomar", Presidente = "Ivo Santos", EpocaCampeonatoPortugues="", EpocaCampeonatoMetropolitano="", EpocaTacaPortugal="", EpocaSupertacaAntonioLivramento="", Historia="A modalidade de H�quei em patins � a modalidade principal deste clube, sendo praticada desde 1950.Na �poca de 1980/81 sagra-se Campe�o Nacional da 2� Divis�o Nacional passando, no ano seguinte a disputar o Campeonato Nacional da 1� Divis�o onde se mant�m largos anos sempre em plano de evid�ncia prestigiando Tomar e esta vasta Regi�o da Zona Centro do Pa�s.Na �poca 2015/16, ap�s vit�ria por 5-0 frente ao Valen�a HC na 2� m�o do apuramento do campe�o, o O SC Tomar conseguiu o seu 4� campeonato nacional da 2� divis�o (1980/81, 1993/94, 1999/00 e 2015/16) ap�s ter conquistado a subida e a 21� presen�a na 1� divis�o nacional.Na �poca de 2016/17, a equipa s�nior de h�quei em patins foi finalista da Ta�a de Portugal pela 1� vez na sua hist�ria. O jogo da final foi frente ao FC Porto, clube que sagrou vencedor do trof�u.", Logotipo="Tomar.jpg"},

            };
            equipas.ForEach(ee => context.Equipas.AddOrUpdate(e => e.ID, ee));
            context.SaveChanges();

            //*********************************************************************************************************************
            // adiciona Jogadores
            var jogadores = new List<Jogadores> {

                //Benfica
               new Jogadores {ID=1, Nome="Pedro Henriques", NomeCompleto="Pedro Miguel Rodrigues Vicente Henriques", N�mero = 1, Posicao="Guarda Redes", DataNascimento= new DateTime(1990,09,27), Nacionalidade="Portugal", Altura=1.86 , Peso=82.0, Fotografia="PedroHenriques.jpg", EquipaPK=1 },
               new Jogadores {ID=2, Nome="Diogo Rafael", NomeCompleto="Diogo Miguel Rafael", N�mero = 4, Posicao="Defesa/M�dio", DataNascimento=new DateTime(1989,11,17), Nacionalidade="Portugal", Altura=1.71, Peso=79.2, Fotografia="DiogoRafael.jpg", EquipaPK=1  },
               new Jogadores {ID=3, Nome="Miguel Rocha", NomeCompleto="Miguel Dami�o Rocha", N�mero = 44, Posicao="Avan�ado", DataNascimento=new DateTime(1993,01,05), Nacionalidade="Portugal", Altura=1.85, Peso=80.1, Fotografia="MiguelRocha.jpg", EquipaPK=1 },
               new Jogadores {ID=4, Nome="Carlos Nicol�a", NomeCompleto="Carlos Fernando Nicol�a Heras", N�mero = 5, Posicao="Avan�ado", DataNascimento=new DateTime(1986,04,04), Nacionalidade="Argentina", Altura=1.80, Peso=79.0, Fotografia="CarlosNicolia.jpg", EquipaPK=1 },
               new Jogadores {ID=5, Nome="Jo�o Rodrigues", NomeCompleto="Jo�o Miguel Braz�o Rodrigues", N�mero = 9, Posicao="Avan�ado", DataNascimento=new DateTime(1990,07,15), Nacionalidade="Portugal", Altura=1.85, Peso=84.4, Fotografia="JoaoRodrigues.jpg", EquipaPK=1 },
               
               //Sporting
               new Jogadores {ID=6, Nome="�ngelo Gir�o", NomeCompleto="�ngelo Andr� Ferreira Gir�o", N�mero = 61, Posicao="Guarda Redes", DataNascimento=new DateTime(1989,08,28), Nacionalidade="Portugal", Altura=1.76, Peso=87.2, Fotografia="AngeloGirao.jpg", EquipaPK=2 },
               new Jogadores {ID=7, Nome="Ferran Font", NomeCompleto="Ferran Font i S�nchez", N�mero = 4, Posicao="Defesa/M�dio", DataNascimento=new DateTime(1996,11,12), Nacionalidade="Espanha", Altura=1.70, Peso=82.7, Fotografia="FerranFont.jpg", EquipaPK=2 },
               new Jogadores {ID=8, Nome="Caio", NomeCompleto="Ricardo do Carmo Oliveira", N�mero = 8, Posicao="Defesa/M�dio", DataNascimento= new DateTime(1982,01,05), Nacionalidade="Portugal", Altura=1.79, Peso=78.0, Fotografia="Caio.jpg", EquipaPK=2  },
               new Jogadores {ID=9, Nome="Pedro Gil", NomeCompleto="Pedro Gil G�mez", N�mero = 9, Posicao="Avan�ado", DataNascimento=new DateTime(1980,04,26), Nacionalidade="Espanha", Altura=1.87, Peso=83.8, Fotografia="PedroGil.jpg", EquipaPK=2 },
               new Jogadores {ID=10, Nome="Jo�o Pinto", NomeCompleto="Jo�o Pedro Garcia Santos Pinto", N�mero = 16, Posicao="Avan�ado", DataNascimento=new DateTime(1987,01,28), Nacionalidade="Angola", Altura=1.75, Peso=78.3, Fotografia="JoaoPinto.jpg", EquipaPK=2 },
              
                //FC Porto
               new Jogadores {ID=11, Nome="Carles Grau", NomeCompleto="Carles Grau Tallada", N�mero = 1, Posicao="Guarda Redes", DataNascimento=new DateTime(1990,03,10), Nacionalidade="Espanha", Altura=1.78, Peso=74.5, Fotografia="CarlesGrau.jpg", EquipaPK=3  },
               new Jogadores {ID=12, Nome="H�lder Nunes", NomeCompleto="H�lder Pereira Nunes", N�mero = 78, Posicao="Defesa/M�dio", DataNascimento=new DateTime(1994,02,23), Nacionalidade="Portugal", Altura=1.78, Peso=89.3, Fotografia="HelderNunes.jpg", EquipaPK=3   },
               new Jogadores {ID=13, Nome="Rafa Costa", NomeCompleto="Jos� Rafael Soares Costa", N�mero = 9, Posicao="Avan�ado", DataNascimento=new DateTime(1991,11,10), Nacionalidade="Portugal", Altura=1.83, Peso=87.2, Fotografia="RafaCosta.jpg", EquipaPK=3   },
               new Jogadores {ID=14, Nome="Jorge Silva", NomeCompleto="Jorge Miguel Sousa Silva", N�mero = 15, Posicao="Avan�ado", DataNascimento=new DateTime(1984,05,09), Nacionalidade="Portugal", Altura=1.87, Peso=81.3, Fotografia="JorgeSilva.jpg", EquipaPK=3   },
               new Jogadores {ID=15, Nome="Gon�alo Alves", NomeCompleto="Gon�alo Bonnet Alves", N�mero = 77, Posicao="Avan�ado", DataNascimento=new DateTime(1993,07,26), Nacionalidade="Portugal", Altura=1.78, Peso=80.0, Fotografia="GoncaloAlves.jpg", EquipaPK=3   },
              
               //UD Oliveirense
               new Jogadores {ID=16, Nome="Xavier Puigb�", NomeCompleto="Xavier Puigb� Martos", N�mero = 88, Posicao="Guarda Redes", DataNascimento=new DateTime(1987,05,23), Nacionalidade="Espanha", Altura=1.83, Peso=76.3, Fotografia="XavierPuigbi.jpg", EquipaPK=4  },
               new Jogadores {ID=17, Nome="Pedro Moreira", NomeCompleto="Pedro Miguel Santos Moreira", N�mero = 7, Posicao="Defesa/M�dio", DataNascimento=new DateTime(1985,07,17), Nacionalidade="Portugal", Altura=1.78, Peso=70.0, Fotografia="PedroMoreira.jpg", EquipaPK=4  },
               new Jogadores {ID=18, Nome="Jordi Bargall�", NomeCompleto="Jordi Bargall� Poch", N�mero = 9, Posicao="Defesa/M�dio", DataNascimento=new DateTime(1979,12,05), Nacionalidade="Espanha", Altura=1.69, Peso=65.0, Fotografia="JordiBargallo.jpg", EquipaPK=4  },
               new Jogadores {ID=19, Nome="Jo�o Souto", NomeCompleto="Jo�o Pedro Souto Silva", N�mero = 44, Posicao="Avan�ado", DataNascimento=new DateTime(1992,07,26), Nacionalidade="Portugal", Altura=1.78, Peso=75.7, Fotografia="JoaoSouto.jpg", EquipaPK=4  },
               new Jogadores {ID=20, Nome="Ricardo Barreiros", NomeCompleto="Ricardo Jorge da Silva Barreiros", N�mero = 77, Posicao="Avan�ado", DataNascimento=new DateTime(1982,01,17), Nacionalidade="Portugal", Altura=1.81, Peso=79.0, Fotografia="RicardoBarreiros.jpg", EquipaPK=4  },
            
               //Sp. Tomar 
               new Jogadores {ID=21, Nome="Diogo Alves", NomeCompleto="Diogo Alves Fernandes", N�mero = 47, Posicao="Guarda Redes", DataNascimento=new DateTime(1997,02,04), Nacionalidade="Portugal", Altura=1.78, Peso=79.1, Fotografia="DiogoAlves.jpg", EquipaPK=5 },
               new Jogadores {ID=22, Nome="Pedro Martins", NomeCompleto="Pedro Miguel Silva Martins", N�mero = 74, Posicao="Defesa/M�dio", DataNascimento=new DateTime(1995,05,18), Nacionalidade="Portugal", Altura=1.73, Peso=77.0, Fotografia="PedroMartins.jpg", EquipaPK=5  },
               new Jogadores {ID=23, Nome="Jo�o Sardo", NomeCompleto="Jo�o de Roma Sardo", N�mero = 5, Posicao="Avan�ado", DataNascimento=new DateTime(1996,02,15), Nacionalidade="Portugal", Altura=1.81, Peso=76.2, Fotografia="Jo�oSardo.jpg", EquipaPK=5  },
               new Jogadores {ID=24, Nome="Ivo Silva", NomeCompleto="Ivo Emanuel Sousa Silva", N�mero = 9, Posicao="Avan�ado", DataNascimento=new DateTime(1990,04,01), Nacionalidade="Portugal", Altura=1.80, Peso=79.3, Fotografia="IvoSilva.jpg", EquipaPK=5  },
               new Jogadores {ID=25, Nome="Hern�ni Diniz", NomeCompleto="Hern�ni Pedro Batista Diniz", N�mero = 44, Posicao="Avan�ado", DataNascimento=new DateTime(1994,10,09), Nacionalidade="Portugal", Altura=1.81, Peso=79.4, Fotografia="HernaniDiniz.jpg", EquipaPK=5  },

               };
            jogadores.ForEach(jj => context.Jogadores.AddOrUpdate(j => j.ID, jj));
            context.SaveChanges();

            //******************************************************************************************************************************
            //adiciona multimedia
            var multimedia = new List<Multimedia>
            {
                //Fotos Pedro Henriques
                new Multimedia {ID=1, NomeFotografia="PedroHenriques1.jpg", JogadorPK=1 },
                new Multimedia {ID=2, NomeFotografia="PedroHenriques2.jpg", JogadorPK=1 },
                new Multimedia {ID=3, NomeFotografia="PedroHenriques3.jpg", JogadorPK=1 },
                new Multimedia {ID=4, NomeFotografia="PedroHenriques4.jpg", JogadorPK=1 },
                new Multimedia {ID=5, NomeFotografia="PedroHenriques5.jpg", JogadorPK=1 },
                new Multimedia {ID=6, NomeFotografia="PedroHenriques6.jpg", JogadorPK=1 },

                //Fotos Diogo Rafael
                new Multimedia {ID=7, NomeFotografia="DiogoRafael1.jpg", JogadorPK=2 },
                new Multimedia {ID=8, NomeFotografia="DiogoRafael2.jpg", JogadorPK=2 },
                new Multimedia {ID=9, NomeFotografia="DiogoRafael3.jpg", JogadorPK=2 },
                new Multimedia {ID=10, NomeFotografia="DiogoRafael4.jpg", JogadorPK=21 },
                new Multimedia {ID=11, NomeFotografia="DiogoRafael5.jpg", JogadorPK=2 },
                new Multimedia {ID=12, NomeFotografia="DiogoRafael6.jpg", JogadorPK=2 },

                //Fotos Miguel Rocha
                new Multimedia {ID=13, NomeFotografia="MiguelRocha1.jpg", JogadorPK=3 },
                new Multimedia {ID=14, NomeFotografia="MiguelRocha2.jpg", JogadorPK=3 },
                new Multimedia {ID=15, NomeFotografia="MiguelRocha3.jpg", JogadorPK=3 },
                new Multimedia {ID=16, NomeFotografia="MiguelRocha4.jpg", JogadorPK=3 },
                new Multimedia {ID=17, NomeFotografia="MiguelRocha5.jpg", JogadorPK=3 },
                new Multimedia {ID=18, NomeFotografia="MiguelRocha6.jpg", JogadorPK=3 },

                // Fotos Carlos Nicolia
                new Multimedia {ID=19, NomeFotografia="CarlosNicolia1.jpg", JogadorPK=4 },
                new Multimedia {ID=20, NomeFotografia="CarlosNicolia2.jpg", JogadorPK=4 },
                new Multimedia {ID=21, NomeFotografia="CarlosNicolia3.jpg", JogadorPK=4 },
                new Multimedia {ID=22, NomeFotografia="CarlosNicolia4.jpg", JogadorPK=4 },
                new Multimedia {ID=23, NomeFotografia="CarlosNicolia5.jpg", JogadorPK=4 },

                // Fotos Jo�o Rodrigues
                new Multimedia {ID=24, NomeFotografia="JoaoRodrigues1.jpg", JogadorPK=5 },
                new Multimedia {ID=25, NomeFotografia="JoaoRodrigues2.jpg", JogadorPK=5 },
                new Multimedia {ID=26, NomeFotografia="JoaoRodrigues3.jpg", JogadorPK=5 },
                new Multimedia {ID=27, NomeFotografia="JoaoRodrigues4.jpg", JogadorPK=5 },
                new Multimedia {ID=28, NomeFotografia="JoaoRodrigues5.jpg", JogadorPK=5 },
                new Multimedia {ID=29, NomeFotografia="JoaoRodrigues6.jpg", JogadorPK=5 },

                //Fotos �ngelo Gir�o
                new Multimedia {ID=30, NomeFotografia="AngeloGirao1.jpg", JogadorPK=6 },
                new Multimedia {ID=31, NomeFotografia="AngeloGirao2.jpg", JogadorPK=6 },
                new Multimedia {ID=32, NomeFotografia="AngeloGirao3.jpg", JogadorPK=6 },
                new Multimedia {ID=33, NomeFotografia="AngeloGirao4.JPG", JogadorPK=6 },
                new Multimedia {ID=34, NomeFotografia="AngeloGirao5.JPG", JogadorPK=6 },

                //Fotos Ferran Font
                new Multimedia {ID=35, NomeFotografia="FerraFont1.jpg", JogadorPK=7 },
                new Multimedia {ID=36, NomeFotografia="FerranFont2.jpg", JogadorPK=7 },
                new Multimedia {ID=37, NomeFotografia="FerranFont3.jpg", JogadorPK=7 },
                new Multimedia {ID=38, NomeFotografia="FerranFont4.jpg", JogadorPK=7 },

                //Fotos Caio
                new Multimedia {ID=39, NomeFotografia="Caio1.jpg", JogadorPK=8 },
                new Multimedia {ID=40, NomeFotografia="Caio2.jpg", JogadorPK=8 },
                new Multimedia {ID=41, NomeFotografia="Caio3.jpg", JogadorPK=8 },
                new Multimedia {ID=42, NomeFotografia="Caio4.jpg", JogadorPK=8 },
                new Multimedia {ID=43, NomeFotografia="Caio5.jpg", JogadorPK=8 },

                //Fotos Pedro Gil
                new Multimedia {ID=44, NomeFotografia="PedroGil1.jpg", JogadorPK=9 },
                new Multimedia {ID=45, NomeFotografia="PedroGil2.jpg", JogadorPK=9 },
                new Multimedia {ID=46, NomeFotografia="PedroGil3.jpg", JogadorPK=9 },
                new Multimedia {ID=47, NomeFotografia="PedroGil4.jpg", JogadorPK=9 },
                new Multimedia {ID=48, NomeFotografia="PedroGil5.jpg", JogadorPK=9 },
                new Multimedia {ID=48, NomeFotografia="PedroGil6.jpg", JogadorPK=9 },

                //Fotos Jo�o Pinto
                new Multimedia {ID=49, NomeFotografia="JoaoPinto1.jpg", JogadorPK=10 },
                new Multimedia {ID=50, NomeFotografia="JoaoPinto2.jpg", JogadorPK=10 },
                new Multimedia {ID=51, NomeFotografia="JoaoPinto3.jpg", JogadorPK=10 },
                new Multimedia {ID=52, NomeFotografia="JoaoPinto4.JPG", JogadorPK=10 },
                new Multimedia {ID=53, NomeFotografia="JoaoPinto5.JPG", JogadorPK=10 },
                new Multimedia {ID=54, NomeFotografia="JoaoPinto6.JPG", JogadorPK=10 },

                //Fotos Carles Grau
                 new Multimedia {ID=55, NomeFotografia="CarlesGrau1.jpg", JogadorPK=11 },
                new Multimedia {ID=56, NomeFotografia="CarlesGrau2.jpg", JogadorPK=11 },
                new Multimedia {ID=57, NomeFotografia="CarlesGrau3.jpg", JogadorPK=11 },
                new Multimedia {ID=58, NomeFotografia="CarlesGrau4.jpg", JogadorPK=11 },
                new Multimedia {ID=59, NomeFotografia="CarlesGrau5.jpg", JogadorPK=11 },

                //Fotos Helder Nunes
                new Multimedia {ID=60, NomeFotografia="HelderNunes1.jpg", JogadorPK=12 },
                new Multimedia {ID=61, NomeFotografia="HelderNunes2.jpg", JogadorPK=12 },
                new Multimedia {ID=62, NomeFotografia="HelderNunes3.jpg", JogadorPK=12 },
                new Multimedia {ID=63, NomeFotografia="HelderNunes4.jpg", JogadorPK=12 },
                new Multimedia {ID=64, NomeFotografia="HelderNunes5.jpg", JogadorPK=12 },
                new Multimedia {ID=65, NomeFotografia="HelderNunes6.jpg", JogadorPK=12 },
                new Multimedia {ID=66, NomeFotografia="HelderNunes7.jpg", JogadorPK=12 },

                //Fotos Rafa Costa
                new Multimedia {ID=67, NomeFotografia="Rafa1.jpg", JogadorPK=13 },
                new Multimedia {ID=68, NomeFotografia="Rafa2.jpg", JogadorPK=13 },
                new Multimedia {ID=69, NomeFotografia="Rafa3.jpg", JogadorPK=13 },
                new Multimedia {ID=70, NomeFotografia="Rafa4.jpg", JogadorPK=13 },
                new Multimedia {ID=71, NomeFotografia="Rafa5.jpg", JogadorPK=13 },

                //Fotos Jorge Silva
                new Multimedia {ID=72, NomeFotografia="JorgeSilva1.jpg", JogadorPK=14 },
                new Multimedia {ID=73, NomeFotografia="JorgeSilva2.jpg", JogadorPK=14 },
                new Multimedia {ID=74, NomeFotografia="JorgeSilva3.jpg", JogadorPK=14 },
                new Multimedia {ID=75, NomeFotografia="JorgeSilva4.jpg", JogadorPK=14 },
                new Multimedia {ID=76, NomeFotografia="JorgeSilva5.jpg", JogadorPK=14 },
                new Multimedia {ID=77, NomeFotografia="JorgeSilva6.jpg", JogadorPK=14 },

                //Gon�alo Alves
                new Multimedia {ID=78, NomeFotografia="GoncaloAlves1.jpg", JogadorPK=15 },
                new Multimedia {ID=79, NomeFotografia="GoncaloAlves2.jpg", JogadorPK=15 },
                new Multimedia {ID=80, NomeFotografia="GoncaloAlves3.jpg", JogadorPK=15 },
                new Multimedia {ID=81, NomeFotografia="Gon�aloAlves4.jpg", JogadorPK=15 },
                new Multimedia {ID=82, NomeFotografia="GoncaloAlves5.jpg", JogadorPK=15 },
                new Multimedia {ID=83, NomeFotografia="GoncaloAlves6.jpg", JogadorPK=15 },

                //Fotos Xavier Puigb�
                new Multimedia {ID=85, NomeFotografia="XavierPuigbi1.jpg", JogadorPK=16 },
                new Multimedia {ID=86, NomeFotografia="XavierPuigbi2.jpg", JogadorPK=16 },
                new Multimedia {ID=87, NomeFotografia="XavierPuigbi3.jpg", JogadorPK=16 },
                new Multimedia {ID=88, NomeFotografia="XavierPuigbi4.jpg", JogadorPK=16 },

                //Fotos Pedro Moreira
                new Multimedia {ID=89, NomeFotografia="PedroMoreira1.jpg", JogadorPK=17 },
                new Multimedia {ID=90, NomeFotografia="PedroMoreira2.jpg", JogadorPK=17 },
                new Multimedia {ID=91, NomeFotografia="PedroMoreira3.jpg", JogadorPK=17 },
                new Multimedia {ID=92, NomeFotografia="PedroMoreira4.jpg", JogadorPK=17 },
                new Multimedia {ID=93, NomeFotografia="PedroMoreira5.jpg", JogadorPK=17 },

                //Fotos de Jordi Bargallo
                new Multimedia {ID=94, NomeFotografia="JordiBargallo1.jpg", JogadorPK=18 },
                new Multimedia {ID=95, NomeFotografia="JordiBargallo2.jpg", JogadorPK=18 },
                new Multimedia {ID=96, NomeFotografia="JordiBargallo3.jpg", JogadorPK=18 },
                new Multimedia {ID=97, NomeFotografia="JordiBargallo4.jpg", JogadorPK=18 },
                new Multimedia {ID=98, NomeFotografia="JordiBargallo5.jpg", JogadorPK=18 },
                new Multimedia {ID=99, NomeFotografia="JordiBargallo6.jpg", JogadorPK=18 },

                //Fotos Jo�o Souto
                new Multimedia {ID=100, NomeFotografia="JoaoSouto1.jpg", JogadorPK=19 },
                new Multimedia {ID=101, NomeFotografia="JoaoSouto2.jpg", JogadorPK=19 },
                new Multimedia {ID=102, NomeFotografia="JoaoSouto3.jpg", JogadorPK=19 },
                new Multimedia {ID=103, NomeFotografia="JoaoSouto4.jpg", JogadorPK=19 },
                new Multimedia {ID=104, NomeFotografia="JoaoSouto5.jpg", JogadorPK=19 },
                new Multimedia {ID=105, NomeFotografia="JoaoSouto6.jpg", JogadorPK=19 },

                //Fotos Ricardo Barreiros
                new Multimedia {ID=106, NomeFotografia="RicardoBarreiros1.jpg", JogadorPK=20 },
                new Multimedia {ID=107, NomeFotografia="RicardoBarreiros2.jpg", JogadorPK=20 },
                new Multimedia {ID=108, NomeFotografia="RicardoBarreiros3.jpg", JogadorPK=20 },
                new Multimedia {ID=109, NomeFotografia="RicardoBarreiros4.jpg", JogadorPK=20 },
                new Multimedia {ID=110, NomeFotografia="RicardoBarreiros5.jpg", JogadorPK=20 },
                new Multimedia {ID=111, NomeFotografia="RicardoBarreiros6.jpg", JogadorPK=20 },

                //Fotos Diogo Alves
                new Multimedia {ID=112, NomeFotografia="DiogoAlves1.jpg", JogadorPK=21 },
                new Multimedia {ID=113, NomeFotografia="DiogoAlves2.jpg", JogadorPK=21 },
                new Multimedia {ID=114, NomeFotografia="DiogoAlves3.jpg", JogadorPK=21 },
                new Multimedia {ID=114, NomeFotografia="DiogoAlves4.jpg", JogadorPK=21 },
                new Multimedia {ID=116, NomeFotografia="DiogoAlves5.jpg", JogadorPK=21 },

                 //Fotos Pedro Martins
                new Multimedia {ID=117, NomeFotografia="PedroMartins1.jpg", JogadorPK=22 },
                new Multimedia {ID=118, NomeFotografia="PedroMartins2.jpg", JogadorPK=22 },
                new Multimedia {ID=119, NomeFotografia="PedroMartins3.jpg", JogadorPK=22 },
                new Multimedia {ID=120, NomeFotografia="PedroMartins4.JPG", JogadorPK=22 },
                new Multimedia {ID=121, NomeFotografia="PedroMartins5.JPG", JogadorPK=22 },
                new Multimedia {ID=122, NomeFotografia="PedroMartins6.JPG", JogadorPK=22 },

                //Fotos Jo�o Sardo
                new Multimedia {ID=123, NomeFotografia="JoaoSardo1.jpg", JogadorPK=23 },
                new Multimedia {ID=124, NomeFotografia="JoaoSardo2.jpg", JogadorPK=23 },
                new Multimedia {ID=125, NomeFotografia="JoaoSardo3.JPG", JogadorPK=23 },
                new Multimedia {ID=126, NomeFotografia="JoaoSardo4.JPG", JogadorPK=23 },
                new Multimedia {ID=127, NomeFotografia="JoaoSardo5.JPG", JogadorPK=23 },
                
                //Fotos Ivo Silva
                new Multimedia {ID=128, NomeFotografia="IvoSilva1.jpg", JogadorPK=24 },
                new Multimedia {ID=129, NomeFotografia="IvoSilva2.jpg", JogadorPK=24 },
                new Multimedia {ID=130, NomeFotografia="IvoSilva3.jpg", JogadorPK=24 },
                new Multimedia {ID=131, NomeFotografia="IvoSilva4.jpg", JogadorPK=24 },
                new Multimedia {ID=132, NomeFotografia="IvoSilva5.jpg", JogadorPK=24 },
                new Multimedia {ID=133, NomeFotografia="IvoSilva6.jpg", JogadorPK=24 },
                
                //Fotos Hernani Diniz
                new Multimedia {ID=134, NomeFotografia="HernaniDiniz1.jpg", JogadorPK=25 },
                new Multimedia {ID=135, NomeFotografia="HernaniDiniz2.JPG", JogadorPK=25 },
                new Multimedia {ID=136, NomeFotografia="HernaniDiniz3.jpg", JogadorPK=25 },
                new Multimedia {ID=137, NomeFotografia="HernaniDiniz4.JPG", JogadorPK=25 },
                new Multimedia {ID=138, NomeFotografia="HernaniDiniz5.jpg", JogadorPK=25 },
                new Multimedia {ID=139, NomeFotografia="HernaniDiniz6.jpg", JogadorPK=25 },
            };
            multimedia.ForEach(mm => context.Multimedia.AddOrUpdate(m => m.ID, mm));
            context.SaveChanges();
        }
    }
}

