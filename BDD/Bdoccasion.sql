drop database if exists Bdoccasion;
create database if not exists Bdoccasion;
use Bdoccasion;
create table if not exists Concessionnaire(
idConces int auto_increment,
nom varchar(15),
prenom varchar(15),
adresse varchar(50),
codepostal varchar(5),
ville varchar(20),
primary key(idConces)
);
INSERT INTO Concessionnaire (nom,prenom,adresse,codePostal,ville) VALUES 
('Davolio', 'Jeanne', '5 rue de la poste', '63000', 'CLERMONT-FERRAND'),
('Fuller', 'Philippe', '254 avenue Berthelot', '63000', 'CLERMONT-FERRAND'),
('Daverling', 'Laura', '1 place de Jaude', '63000', 'CLERMONT-FERRAND'),
('Peacock', 'Emilie', '23, Impasse des Fleurs', '63000', 'CLERMONT-FERRAND'),
('Buchanan', 'Pierre', '32 place de l''Hôtel de Ville', '63200', 'RIOM'),
('Bucyama', 'Michel', '15 rue des pinsons', '63200', 'RIOM'),
('King', 'Louis', '57 rue de la gare', '63500', 'ISSOIRE'),
('Callahan', 'Jean', '23 boulevard Central', '63500', 'ISSOIRE'),
('Bucsworth', 'Pierre', '7 rue de la paix', '63500', 'ISSOIRE');
