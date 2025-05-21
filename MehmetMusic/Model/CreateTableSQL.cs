using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;
using System.Xml.Linq;

namespace MehmetMusic.Model
{
     class CreateTableSQL
    {
        /*CREATE TABLE RegestrierungMusicApp(
                userName VARCHAR(20) PRIMARY KEY,
                vorname VARCHAR(10),
                nachname VARCHAR(20),
                email VARCHAR(30),
                birthday DATE); 


        /*CREATE TABLE login(
            username VARCHAR(20) PRIMARY KEY,
            password VARCHAR(20)
        );

        CREATE TABLE Interpreter(
            interpreter_id INT PRIMARY KEY,
            name VARCHAR2(255),
            image VARCHAR2(255)
        );


        CREATE TABLE Album(
            album_id INT PRIMARY KEY,
            titel VARCHAR2(255),
            image VARCHAR2(255),
            interpreter_id INT,
            FOREIGN KEY(interpreter_id) REFERENCES Interpreter(interpreter_id)
        );


            CREATE TABLE Track(
                track_id INT PRIMARY KEY,
                titel VARCHAR2(255),
                titelshort VARCHAR2(255),
                explicit_lyrics NUMERIC(1),
                dauer_sec INT,
                rang INT,
                tracklink VARCHAR2(255),
                album_id INT,
                interpreter_id INT,
                FOREIGN KEY(album_id) REFERENCES Album(album_id),
                FOREIGN KEY(interpreter_id) REFERENCES Interpreter(interpreter_id)
            );


            */
    }
}
