create database nghegihomnay
go

use nghegihomnay
go


create table playlist
(
	id int identity (1,1) primary key,
	name nvarchar(100) not null,
	nearest_change datetime,
)

create table album
(
	id int identity (1,1) primary key,
	name nvarchar(100) not null,
)

create table songtype
(
	id int identity (1,1) primary key,
	name nvarchar(100) not null,
)

create table song
(
	id int identity (1,1) primary key,
	song_path nvarchar(300) not null,
	lyric_path nvarchar(300) not null,
	image_path nvarchar(300) not null,
	name nvarchar(100) not null,
	singer nvarchar(100),
	name_album nvarchar(200),
	id_album int,
	name_playlist nvarchar(200),
	id_playlist int,
	song_type nvarchar(100),
	song_type_id int,	
)

----------------------
SET IDENTITY_INSERT dbo.playlist ON
insert into dbo.playlist (id, name)
values 
(1, N'Gym'),
(2, N'Học Tập'),
(3, N'Thư giãn'),
(4, N'Giải trí');
SET IDENTITY_INSERT dbo.playlist OFF
-----------------------------
select * from playlist

----------------------
SET IDENTITY_INSERT dbo.album ON
insert into dbo.album(id, name)
values
(1, N'Coffee Weekend'),
(2, N'Doi Minh Di Ben Nhau - Playlist Danh Cho Du Lich'),
(3, N'EDM Best Remixes'),
(4, N'Nhac Viet Remix Hot Thang 012021');
SET IDENTITY_INSERT dbo.album OFF
-----------------------------------------
select * from dbo.album
---------------------------------------
SET IDENTITY_INSERT dbo.songtype ON
insert into dbo.songtype (id, name)
values 
(1, N'Nhạc nước ngoài'),
(2, N'Nhạc trẻ'),
(3, N'Nhạc remix');
SET IDENTITY_INSERT dbo.songtype OFF

--SET IDENTITY_INSERT dbo.song ON
insert into dbo.song (song_path, lyric_path, image_path, name, singer ,	name_album, id_album, name_playlist, id_playlist, song_type, song_type_id)
values 
(N'D:\Song\Nghe gì hôm nay\Coffee Weekend\A Place We Knew  -  Dean Lewis.mp3', N'D:\Lyrics\Nghe gì hôm nay\Coffee Weekend\A Place We Knew.txt', N'D:\Images\Nghe gì hôm nay\Coffee Weekend\A Place We Knew.jpg', N'A Place We Knew', N'Dean Lewis', N'Coffee Weekend', 1, N'Gym', 1, N'Nhạc nước ngoài',1),
(N'D:\Song\Nghe gì hôm nay\Coffee Weekend\All Of Me  -  Jon Schmidt, Steven Sharp Nelson.mp3', N'D:\Lyrics\Nghe gì hôm nay\Coffee Weekend\All of Me.txt', N'D:\Images\Nghe gì hôm nay\Coffee Weekend\All Of Me.jpg', N'All Of Me', N'Jon Schmidt, Steven Sharp Nelson',	N'Coffee Weekend', 1, N'Học Tập', 2, N'Nhạc nước ngoài',1),
(N'D:\Song\Nghe gì hôm nay\Coffee Weekend\Budapest  -  George Ezra.mp3', N'D:\Lyrics\Nghe gì hôm nay\Coffee Weekend\Budapest.txt', N'D:\Images\Nghe gì hôm nay\Coffee Weekend\Budapest.jpg', N'Budapest', N'George Ezra', N'Coffee Weekend', 1, N'Thư giãn', 3, N'Nhạc nước ngoài',1),
(N'D:\Song\Nghe gì hôm nay\Coffee Weekend\Eye Of The Needle  -  Sia.mp3', N'D:\Lyrics\Nghe gì hôm nay\Coffee Weekend\Eye Of The Needle.txt', N'D:\Images\Nghe gì hôm nay\Coffee Weekend\Eye Of The Needle.jpg', N'Eye Of The Needle', N'Sia', N'Coffee Weekend', 1, N'Thư giãn', 3, N'Nhạc nước ngoài',1),
(N'D:\Song\Nghe gì hôm nay\Coffee Weekend\Habits  -  Tove Lo, The Chainsmokers.mp3', N'D:\Lyrics\Nghe gì hôm nay\Coffee Weekend\Habits.txt', N'D:\Images\Nghe gì hôm nay\Coffee Weekend\Habits.jpg', N'Habits', N'Tove Lo, The Chainsmokers', N'Coffee Weekend', 1, N'Giải trí', 4, N'Nhạc nước ngoài',1),
(N'D:\Song\Nghe gì hôm nay\Coffee Weekend\Love Someone  -  Miley Cyrus.mp3', N'D:\Lyrics\Nghe gì hôm nay\Coffee Weekend\Love Someone.txt', N'D:\Images\Nghe gì hôm nay\Coffee Weekend\Love Someone.jpg', N'Love Someone', N'Miley Cyrus', N'Coffee Weekend', 1, N'Thư giãn', 3, N'Nhạc nước ngoài',1),
(N'D:\Song\Nghe gì hôm nay\Coffee Weekend\Love Yourself  -  Justin Bieber.mp3', N'D:\Lyrics\Nghe gì hôm nay\Coffee Weekend\Love Yourself.txt', N'D:\Images\Nghe gì hôm nay\Coffee Weekend\Love Yourself.jpg', N'Love Yourself', N'Justin Bieber', N'Coffee Weekend', 1, N'Thư giãn', 3, N'Nhạc nước ngoài',1),
(N'D:\Song\Nghe gì hôm nay\Coffee Weekend\Melt Away  -  Mariah Carey.mp3', N'D:\Lyrics\Nghe gì hôm nay\Coffee Weekend\Melt Away.txt', N'D:\Images\Nghe gì hôm nay\Coffee Weekend\Melt Away.jpg', N'Melt Away', N'Mariah Carey', N'Coffee Weekend', 1, N'Giải trí', 4, N'Nhạc nước ngoài',1),
(N'D:\Song\Nghe gì hôm nay\Coffee Weekend\Mess Is Mine  -  Jessica Mauboy.mp3', N'D:\Lyrics\Nghe gì hôm nay\Coffee Weekend\Mess Is Mine.txt', N'D:\Images\Nghe gì hôm nay\Coffee Weekend\Mess Is Mine.jpg', N'Mess Is Mine', N'Jessica Mauboy', N'Coffee Weekend', 1, N'Gym', 1, N'Nhạc nước ngoài',1),
(N'D:\Song\Nghe gì hôm nay\Coffee Weekend\Not With Me  -  Wiktoria.mp3', N'D:\Lyrics\Nghe gì hôm nay\Coffee Weekend\Not With Me.txt', N'D:\Images\Nghe gì hôm nay\Coffee Weekend\Not With Me.jpg', N'Not With Me', N'Wiktoria', N'Coffee Weekend', 1, N'Giải trí', 4, N'Nhạc nước ngoài',1),
(N'D:\Song\Nghe gì hôm nay\Coffee Weekend\Say Something  -  A Great Big World, Christina Aguilera.mp3', N'D:\Lyrics\Nghe gì hôm nay\Coffee Weekend\Say Something.txt', N'D:\Images\Nghe gì hôm nay\Coffee Weekend\Say Something.jpg', N'Say Something', N'A Great Big World,Christina Aguilera', N'Coffee Weekend', 1, N'Thư giãn', 3, N'Nhạc nước ngoài',1),
(N'D:\Song\Nghe gì hôm nay\Coffee Weekend\Take Me To The Church (Acapella)  -  Hardwell, DallasK.mp3', N'D:\Lyrics\Nghe gì hôm nay\Coffee Weekend\Take Me To The Church (Acapella).txt', N'D:\Images\Nghe gì hôm nay\Coffee Weekend\Take Me To The Church (Acapella).jpg', N'Take Me To The Church (Acapella)', N'Hardwell, DallasK', N'Coffee Weekend', 1, N'Giải trí', 4, N'Nhạc nước ngoài',1),
(N'D:\Song\Nghe gì hôm nay\Coffee Weekend\Thinking Out Loud  -  Chris Brown.mp3', N'D:\Lyrics\Nghe gì hôm nay\Coffee Weekend\Thinking Out Loud.txt', N'D:\Images\Nghe gì hôm nay\Coffee Weekend\Thinking Out Loud.jpg', N'Thinking Out Loud', N'Chris Brown', N'Coffee Weekend', 1, N'Gym', 1, N'Nhạc nước ngoài',1),
(N'D:\Song\Nghe gì hôm nay\Coffee Weekend\You Are The Reason  -  Calum Scott.mp3', N'D:\Lyrics\Nghe gì hôm nay\Coffee Weekend\You Are The Reason.txt', N'D:\Images\Nghe gì hôm nay\Coffee Weekend\You Are The Reason.jpg', N'You Are The Reason', N'Calum Scott', N'Coffee Weekend', 1, N'Gym', 1, N'Nhạc nước ngoài',1);
go

insert into dbo.song (song_path, lyric_path, image_path, name, singer ,	name_album, id_album, name_playlist, id_playlist, song_type, song_type_id)
values 
(N'D:\Song\Nghe gì hôm nay\Doi Minh Di Ben Nhau - Playlist Danh Cho Du Lich\Bac Tai Oi  -  Le Thien Hieu.mp3',	N'D:\Lyrics\Nghe gì hôm nay\Doi Minh Di Ben Nhau - Playlist Danh Cho Du Lich\Bác Tài Ơi.txt',	N'D:\Images\Nghe gì hôm nay\Doi Minh Di Ben Nhau - Playlist Danh Cho Du Lich\Bác Tài Ơi.jpg',	N'Bác Tài Ơi',	N'Lê Thiện Hiếu',	N'Doi Minh Di Ben Nhau - Playlist Danh Cho Du Lich',	2,	N'Giải trí',	4,	N'Nhạc trẻ',2),
(N'D:\Song\Nghe gì hôm nay\Doi Minh Di Ben Nhau - Playlist Danh Cho Du Lich\Ben Do Troi  -  Huyen Mikii, Masta Trippy.mp3',	N'D:\Lyrics\Nghe gì hôm nay\Doi Minh Di Ben Nhau - Playlist Danh Cho Du Lich\Bến Đỗ Trôi.txt',	N'D:\Images\Nghe gì hôm nay\Doi Minh Di Ben Nhau - Playlist Danh Cho Du Lich\Bến Đỗ Trôi.jpg',	N'Bến Đỗ Trôi',	N'Huyền Mikii, Masta Trippy',	N'Doi Minh Di Ben Nhau - Playlist Danh Cho Du Lich',	2,	N'Giải trí',	4,	N'Nhạc trẻ',2),
(N'D:\Song\Nghe gì hôm nay\Doi Minh Di Ben Nhau - Playlist Danh Cho Du Lich\Can Gi Hon  -  Tien Tien, JustaTee.mp3',	N'D:\Lyrics\Nghe gì hôm nay\Doi Minh Di Ben Nhau - Playlist Danh Cho Du Lich\Cần Gì Hơn.txt',	N'D:\Images\Nghe gì hôm nay\Doi Minh Di Ben Nhau - Playlist Danh Cho Du Lich\Cần Gì Hơn.jpg',	N'Cần Gì Hơn?',	N'Tiên Tiên, JustaTee',	N'Doi Minh Di Ben Nhau - Playlist Danh Cho Du Lich',	2,	N'Học Tập',	2,	N'Nhạc trẻ',2),
(N'D:\Song\Nghe gì hôm nay\Doi Minh Di Ben Nhau - Playlist Danh Cho Du Lich\Con Song Con Yeu  -  Thanh Ha, Orange, Tuimi, Chau Nhi.mp3',	N'D:\Lyrics\Nghe gì hôm nay\Doi Minh Di Ben Nhau - Playlist Danh Cho Du Lich\Còn Sống Còn Yêu.txt',	N'D:\Images\Nghe gì hôm nay\Doi Minh Di Ben Nhau - Playlist Danh Cho Du Lich\Còn Sống Còn Yêu.jpg',	N'Còn Sống Còn Yêu',	N'Thanh Hà, Orange, Tuimi, Châu Nhi',	N'Doi Minh Di Ben Nhau - Playlist Danh Cho Du Lich',	2,	N'Gym',	1,	N'Nhạc trẻ',2),
(N'D:\Song\Nghe gì hôm nay\Doi Minh Di Ben Nhau - Playlist Danh Cho Du Lich\Da Lat Toi  -  Chu Viet, Daniel, V.O.X.mp3',	N'D:\Lyrics\Nghe gì hôm nay\Doi Minh Di Ben Nhau - Playlist Danh Cho Du Lich\Đà Lạt Tôi.txt',	N'D:\Images\Nghe gì hôm nay\Doi Minh Di Ben Nhau - Playlist Danh Cho Du Lich\Đà Lạt Tôi.jpg',	N'Đà Lạt Tôii',	N'Chú Việt, Daniel, V.O.X',	N'Doi Minh Di Ben Nhau - Playlist Danh Cho Du Lich',	2,	N'Giải trí',	4,	N'Nhạc remix',3),
(N'D:\Song\Nghe gì hôm nay\Doi Minh Di Ben Nhau - Playlist Danh Cho Du Lich\Di Het Thoi Tuoi Tre (Version 2020)  -  Ha.mp3',	N'D:\Lyrics\Nghe gì hôm nay\Doi Minh Di Ben Nhau - Playlist Danh Cho Du Lich\Đi Hết Thời Tuổi Trẻ (Version 2020).txt',	N'D:\Images\Nghe gì hôm nay\Doi Minh Di Ben Nhau - Playlist Danh Cho Du Lich\Đi Hết Thời Tuổi Trẻ (Version 2020).jpg',	N'Đi Hết Thời Tuổi Trẻ (Version 2020)',	N'Hà',	N'Doi Minh Di Ben Nhau - Playlist Danh Cho Du Lich',	2,	N'Gym',	1	,N'Nhạc trẻ',2),
(N'D:\Song\Nghe gì hôm nay\Doi Minh Di Ben Nhau - Playlist Danh Cho Du Lich\Doi Minh Di Ben Nhau  -  Linh Cao.mp3',	N'D:\Lyrics\Nghe gì hôm nay\Doi Minh Di Ben Nhau - Playlist Danh Cho Du Lich\Đôi Mình Đi Bên Nhau.txt',	N'D:\Images\Nghe gì hôm nay\Doi Minh Di Ben Nhau - Playlist Danh Cho Du Lich\Đôi Mình Đi Bên Nhau.jpg',	N'Đôi Mình Đi Bên Nhau',	N'Linh Cáo',	N'Doi Minh Di Ben Nhau - Playlist Danh Cho Du Lich',	2,	N'Giải trí',	4,	N'Nhạc trẻ',2),
(N'D:\Song\Nghe gì hôm nay\Doi Minh Di Ben Nhau - Playlist Danh Cho Du Lich\Lam Moi Toi Ngoi Khong  -  Hoang Thuy Linh.mp3',	N'D:\Lyrics\Nghe gì hôm nay\Doi Minh Di Ben Nhau - Playlist Danh Cho Du Lich\Lắm Mối Tối Ngồi không.txt',	N'D:\Images\Nghe gì hôm nay\Doi Minh Di Ben Nhau - Playlist Danh Cho Du Lich\Lắm Mối Tối Ngồi không.jpg',	N'Lắm Mối Tối Ngồi Không',	N'Hoang Thuy Linh',	N'Doi Minh Di Ben Nhau - Playlist Danh Cho Du Lich',	2,	N'Gym',	1,	N'Nhạc trẻ',2),
(N'D:\Song\Nghe gì hôm nay\Doi Minh Di Ben Nhau - Playlist Danh Cho Du Lich\Love Mood  -  Lang LD, Khoa.mp3',	N'D:\Lyrics\Nghe gì hôm nay\Doi Minh Di Ben Nhau - Playlist Danh Cho Du Lich\Love Mood.txt',	N'D:\Images\Nghe gì hôm nay\Doi Minh Di Ben Nhau - Playlist Danh Cho Du Lich\Love Mood.jpg',	N'Love Mood',	N'Khoa, Lăng LD',	N'Doi Minh Di Ben Nhau - Playlist Danh Cho Du Lich',	2,	N'Giải trí',	4,	N'Nhạc remix',3),
(N'D:\Song\Nghe gì hôm nay\Doi Minh Di Ben Nhau - Playlist Danh Cho Du Lich\May Lang Thang  -  Tung TeA, PC, NewSoulZ.mp3',	N'D:\Lyrics\Nghe gì hôm nay\Doi Minh Di Ben Nhau - Playlist Danh Cho Du Lich\Mây Lang Thang.txt',	N'D:\Images\Nghe gì hôm nay\Doi Minh Di Ben Nhau - Playlist Danh Cho Du Lich\Mây Lang Thang.jpg',	N'Mây Lang Thang',	N'TeA, PC, NewSoulZ',	N'Doi Minh Di Ben Nhau - Playlist Danh Cho Du Lich',	2,	N'Học Tập',	2,	N'Nhạc remix',3),
(N'D:\Song\Nghe gì hôm nay\Doi Minh Di Ben Nhau - Playlist Danh Cho Du Lich\Nhung Ngay Di Lac  -  Linh Cao.mp3',	N'D:\Lyrics\Nghe gì hôm nay\Doi Minh Di Ben Nhau - Playlist Danh Cho Du Lich\Những Ngày Đi Lạc.txt',	N'D:\Images\Nghe gì hôm nay\Doi Minh Di Ben Nhau - Playlist Danh Cho Du Lich\Những Ngày Đi Lạc.jpg',	N'Những Ngày Đi Lạc',	N'Linh Cáo',	N'Doi Minh Di Ben Nhau - Playlist Danh Cho Du Lich',	2,	N'Giải trí',	4,	N'Nhạc remix',3),
(N'D:\Song\Nghe gì hôm nay\Doi Minh Di Ben Nhau - Playlist Danh Cho Du Lich\Runaway  -  Thoai 004.mp3',	N'D:\Lyrics\Nghe gì hôm nay\Doi Minh Di Ben Nhau - Playlist Danh Cho Du Lich\Runaway.txt',	N'D:\Images\Nghe gì hôm nay\Doi Minh Di Ben Nhau - Playlist Danh Cho Du Lich\Runaway.jpg',	N'Runaway',	N'Thoại 004',	N'Doi Minh Di Ben Nhau - Playlist Danh Cho Du Lich',	2,	N'Học Tập',	2,	N'Nhạc remix',3),
(N'D:\Song\Nghe gì hôm nay\Doi Minh Di Ben Nhau - Playlist Danh Cho Du Lich\Song Cho Het Doi Thanh Xuan  -  Dick, Xam, Tuyet.mp3',	N'D:\Lyrics\Nghe gì hôm nay\Doi Minh Di Ben Nhau - Playlist Danh Cho Du Lich\Sống Cho Hết Đời Thanh Xuân.txt',	N'D:\Images\Nghe gì hôm nay\Doi Minh Di Ben Nhau - Playlist Danh Cho Du Lich\Sống Cho Hết Đời Thanh Xuân.png',	N'Sống Cho Hết Đời Thanh Xuân',	N'Dick, Xám, Tuyết',	N'Doi Minh Di Ben Nhau - Playlist Danh Cho Du Lich',	2,	N'Giải trí',	4,	N'Nhạc remix',3),
(N'D:\Song\Nghe gì hôm nay\Doi Minh Di Ben Nhau - Playlist Danh Cho Du Lich\Song Cho Het Doi Thanh Xuan 2  -  BCTM, TNS.mp3',	N'D:\Lyrics\Nghe gì hôm nay\Doi Minh Di Ben Nhau - Playlist Danh Cho Du Lich\Sống Cho Hết Đời Thanh Xuân 2.txt',	N'D:\Images\Nghe gì hôm nay\Doi Minh Di Ben Nhau - Playlist Danh Cho Du Lich\Sống Cho Hết Đời Thanh Xuân 2.png',	N'Sống Cho Hết Đời Thanh Xuân 2',	N'BCTM, TNS',	N'Doi Minh Di Ben Nhau - Playlist Danh Cho Du Lich',	2,	N'Gym',	1,	N'Nhạc remix',3),
(N'D:\Song\Nghe gì hôm nay\Doi Minh Di Ben Nhau - Playlist Danh Cho Du Lich\Yeu Di Cho Chi (I Like U 2)  -  Mlee.mp3',	N'D:\Lyrics\Nghe gì hôm nay\Doi Minh Di Ben Nhau - Playlist Danh Cho Du Lich\Yêu Đi Chờ Chi (I Like U 2).txt',	N'D:\Images\Nghe gì hôm nay\Doi Minh Di Ben Nhau - Playlist Danh Cho Du Lich\Yêu Đi Chờ Chi (I Like U 2).jpg',	N'Yêu Đi Chờ Chi (I Like U 2)',	N'Mlee',	N'Doi Minh Di Ben Nhau - Playlist Danh Cho Du Lich',	2,	N'Giải trí',	4,	N'Nhạc remix',3);
go

insert into dbo.song (song_path, lyric_path, image_path, name, singer ,	name_album, id_album, name_playlist, id_playlist, song_type, song_type_id)
values 
(N'D:\Song\Nghe gì hôm nay\EDM Best Remixes\Aint My Fault (R3hab Remix)  -  Zara Larsson.mp3',	N'D:\Lyrics\Nghe gì hôm nay\EDM Best Remixes\Aint My Fault (R3hab Remix) - Zara Larsson.txt',	N'D:\Images\Nghe gì hôm nay\EDM Best Remixes\Aint My Fault (R3hab Remix) - Zara Larsson.jpg',	N'Aint My Fault (R3hab Remix) - Zara Larsson',	N'Zara Larsson',	N'EDM Best Remixes',	3,	N'Thư giãn',	3,	N'Nhạc remix',3),
(N'D:\Song\Nghe gì hôm nay\EDM Best Remixes\Bad Guy (Tiestos Big Room Remix)  -  Billie Eilish.mp3',	N'D:\Lyrics\Nghe gì hôm nay\EDM Best Remixes\Bad Guy (Tiestos Big Room Remix).txt',	N'D:\Images\Nghe gì hôm nay\EDM Best Remixes\Bad Guy (Tiestos Big Room Remix).jpg',	N'Bad Guy (Tiestos Big Room Remix)',	N'Billie Eilish',	N'EDM Best Remixes',	3,	N'Giải trí',	4,	N'Nhạc remix',3),
(N'D:\Song\Nghe gì hôm nay\EDM Best Remixes\Call You Mine (Parker Remix)  -  The Chainsmokers, Bebe Rexha.mp3',	N'D:\Lyrics\Nghe gì hôm nay\EDM Best Remixes\Call You Mine (Parker Remix).txt',	N'D:\Images\Nghe gì hôm nay\EDM Best Remixes\Call You Mine (Parker Remix).jpg',	N'Call You Mine (Parker Remix)',	N'The Chainsmokers,Bebe Rexha',	N'EDM Best Remixes',	3,	N'Học Tập',	2,	N'Nhạc trẻ',2),
(N'D:\Song\Nghe gì hôm nay\EDM Best Remixes\Closer (T-Mass Remix)  -  The Chainsmokers, Halsey.mp3',	N'D:\Lyrics\Nghe gì hôm nay\EDM Best Remixes\Closer (T Mass Remix).txt',	N'D:\Images\Nghe gì hôm nay\EDM Best Remixes\Closer (T Mass Remix).jpg',	N'Closer (T Mass Remix)',	N'The Chainsmokers, Halsey',	N'EDM Best Remixes',	3,	N'Giải trí',	4,	N'Nhạc remix',3),
(N'D:\Song\Nghe gì hôm nay\EDM Best Remixes\DDu-Du DDu-Du (Remix - Japan Version)  -  BlackPink.mp3',	N'D:\Lyrics\Nghe gì hôm nay\EDM Best Remixes\Ddu-du Ddu-du (Remix Japan Version).txt',	N'D:\Images\Nghe gì hôm nay\EDM Best Remixes\Ddu-du Ddu-du (Remix Japan Version).jpg',	N'Ddu-du Ddu-du (Remix /Japan Version)',	N'BLACKPINK',	N'EDM Best Remixes',	3,	N'Thư giãn',	3,	N'Nhạc remix',3),
(N'D:\Song\Nghe gì hôm nay\EDM Best Remixes\Let Me Love You (Marshmello Remix)  -  DJ Snake, Marshmello, Justin Bieber.mp3',	N'D:\Lyrics\Nghe gì hôm nay\EDM Best Remixes\Let Me Love You.txt',	N'D:\Images\Nghe gì hôm nay\EDM Best Remixes\Let Me Love You.jpg',	N'Let Me Love You',	N'DJ Snake, Marshmello, Justin B',	N'EDM Best Remixes',	3,	N'Gym',	1,	N'Nhạc remix',3),
(N'D:\Song\Nghe gì hôm nay\EDM Best Remixes\Like I Would (Tom Budin Remix)  -  Zayn.mp3',	N'D:\Lyrics\Nghe gì hôm nay\EDM Best Remixes\Like I Would (Tom Budin Remix) - Zayn.txt',	N'D:\Images\Nghe gì hôm nay\EDM Best Remixes\Like I Would (Tom Budin Remix) - Zayn.jpg',	N'Like I Would (Tom Budin Remix) - Zayn',	N'Zayn',	N'EDM Best Remixes',	3,	N'Thư giãn',	3,	N'Nhạc trẻ',2),
(N'D:\Song\Nghe gì hôm nay\EDM Best Remixes\Move Your Body (Alan Walker Remix)  -  Sia.mp3',	N'D:\Lyrics\Nghe gì hôm nay\EDM Best Remixes\Move Your Body (Alan Walker Remix) - Sia.txt',	N'D:\Images\Nghe gì hôm nay\EDM Best Remixes\Move Your Body (Alan Walker Remix) - Sia.jpg',	N'Move Your Body (Alan Walker Remix) - Sia',	N'Sia',	N'EDM Best Remixes',	3,	N'Thư giãn',	3,	N'Nhạc trẻ',2),
(N'D:\Song\Nghe gì hôm nay\EDM Best Remixes\Never Forget You (Price & Takis Remix)  -  Zara Larsson, MNEK.mp3',	N'D:\Lyrics\Nghe gì hôm nay\EDM Best Remixes\Never Forget You (Price & Takis Remix).txt',	N'D:\Images\Nghe gì hôm nay\EDM Best Remixes\Never Forget You (Price & Takis Remix).jpg',	N'Never Forget You (Price & Takis Remix)',	N'Zara Larsson, MNEK',	N'EDM Best Remixes',	3,	N'Giải trí',	4,	N'Nhạc trẻ',2),
(N'D:\Song\Nghe gì hôm nay\EDM Best Remixes\Senorita (M+ike Remix)  -  Shawn Mendes, Camila Cabello.mp3',	N'D:\Lyrics\Nghe gì hôm nay\EDM Best Remixes\Senorita (M+ike Remix).txt',	N'D:\Images\Nghe gì hôm nay\EDM Best Remixes\Senorita (MikeRemix).png',	N'Senorita (M+ike Remix)',	N'Shawn Mendes, Camila Cabello',	N'EDM Best Remixes',	3,	N'Gym',	1,	N'Nhạc nước ngoài',1),
(N'D:\Song\Nghe gì hôm nay\EDM Best Remixes\Something Just Like This (DJ Asher Remix Cover)  -  Romy Wave.mp3',	N'D:\Lyrics\Nghe gì hôm nay\EDM Best Remixes\Something Just Like This (DJ Asher Remix Cover).txt',	N'D:\Images\Nghe gì hôm nay\EDM Best Remixes\Something Just Like This (DJ Asher Remix Cover).jpg',	N'Something Just Like This (DJ Asher Remix Cover)',	N'Romy Wave',	N'EDM Best Remixes',	3,	N'Giải trí',	4,	N'Nhạc trẻ',2),
(N'D:\Song\Nghe gì hôm nay\EDM Best Remixes\Thank U Next (Neovaii Remix)  -  Ariana Grande.mp3',	N'D:\Lyrics\Nghe gì hôm nay\EDM Best Remixes\Thank U Next (Neovaii Remix).txt',	N'D:\Images\Nghe gì hôm nay\EDM Best Remixes\Thank U Next (Neovaii Remix).jpg',	N'Thank U Next (Neovaii Remix)',	N'Ariana Grande',	N'EDM Best Remixes',	3,	N'Thư giãn',	3,	N'Nhạc nước ngoài',1),
(N'D:\Song\Nghe gì hôm nay\EDM Best Remixes\Who Do You Love (R3HAB Remix)  -  The Chainsmokers, 5 Seconds Of Summer.mp3',	N'D:\Lyrics\Nghe gì hôm nay\EDM Best Remixes\Who Do You Love (R3HAB Remix).txt',	N'D:\Images\Nghe gì hôm nay\EDM Best Remixes\Who Do You Love (R3HAB Remix).jpg',	N'Who Do You Love (R3HAB Remix)',	N'The Chainsmokers,5 Seconds of Summer',	N'EDM Best Remixes',	3,	N'Giải trí',	4,	N'Nhạc nước ngoài',1),
(N'D:\Song\Nghe gì hôm nay\EDM Best Remixes\Without Me (Nurko & Miles Away Remix)  -  Halsey.mp3',	N'D:\Lyrics\Nghe gì hôm nay\EDM Best Remixes\Without Me (Nurko & Miles Away Remix).txt',	N'D:\Images\Nghe gì hôm nay\EDM Best Remixes\Without Me (Nurko & Miles Away Remix).jpg',	N'Without Me (Nurko & Miles Away Remix)',	N'Halsey',	N'EDM Best Remixes',	3,	N'Gym',	1,	N'Nhạc trẻ',2);
go

insert into dbo.song (song_path, lyric_path, image_path, name, singer ,	name_album, id_album, name_playlist, id_playlist, song_type, song_type_id)
values 
(N'D:\Song\Nghe gì hôm nay\Nhac Viet Remix Hot Thang 012021\Ai Mang Co Don Di (TanTho Remix) Cover  -  Huong Ly.mp3',	N'D:\Lyrics\Nghe gì hôm nay\Nhac Viet Remix Hot Thang 012021\Ai Mang Cô Đơn Đi (TanTho Remix) Cover.txt',	N'D:\Images\Nghe gì hôm nay\Nhac Viet Remix Hot Thang 012021\Ai Mang Cô Đơn Đi (TanTho Remix) Cover.jpg',	N'Ai Mang Cô Đơn Đi (TanTho Remix) Cover',	N'Hương Ly',	N'Nhac Viet Remix Hot Thang 012021',	4,	N'Giải trí',	4,	N'Nhạc remix',3),
(N'D:\Song\Nghe gì hôm nay\Nhac Viet Remix Hot Thang 012021\Anh Tung Co Gang (ACV Remix)  -  Nhat Phong.mp3',	N'D:\Lyrics\Nghe gì hôm nay\Nhac Viet Remix Hot Thang 012021\Anh Từng Cố Gắng (ACV Remix).txt',	N'D:\Images\Nghe gì hôm nay\Nhac Viet Remix Hot Thang 012021\Anh Từng Cố Gắng (ACV Remix).jpg',	N'Anh Từng Cố Gắng (ACV Remix)',	N'Nhật Phong',	N'Nhac Viet Remix Hot Thang 012021',	4,	N'Giải trí',	4,	N'Nhạc remix',3),
(N'D:\Song\Nghe gì hôm nay\Nhac Viet Remix Hot Thang 012021\Anh Tung Co Gang (Andy Remix)  -  Nhat Phong, DJ Andy.mp3',	N'D:\Lyrics\Nghe gì hôm nay\Nhac Viet Remix Hot Thang 012021\Anh Từng Cố Gắng (Andy Remix).txt',	N'D:\Images\Nghe gì hôm nay\Nhac Viet Remix Hot Thang 012021\Anh Từng Cố Gắng (Andy Remix).jpg',	N'Anh Từng Cố Gắng (Andy Remix)',	N'Nhật Phong, DJ Andy',	N'Nhac Viet Remix Hot Thang 012021',	4,	N'Học Tập',	2,	N'Nhạc remix',3),
(N'D:\Song\Nghe gì hôm nay\Nhac Viet Remix Hot Thang 012021\Boy My Con (Masew Remix)  -  B Ray, Masew.mp3',	N'D:\Lyrics\Nghe gì hôm nay\Nhac Viet Remix Hot Thang 012021\Boy Mỹ Con (Masew Remix).txt',	N'D:\Images\Nghe gì hôm nay\Nhac Viet Remix Hot Thang 012021\Boy Mỹ Con (Masew Remix).jpg',	N'Boy Mỹ Con (Masew Remix)',	N'B Ray, Masew',	N'Nhac Viet Remix Hot Thang 012021',	4,	N'Giải trí',	4,	N'Nhạc remix',3),
(N'D:\Song\Nghe gì hôm nay\Nhac Viet Remix Hot Thang 012021\Chang The Tim Duoc Em (Orinn EDM Remix)  -  PhucXP.mp3',	N'D:\Lyrics\Nghe gì hôm nay\Nhac Viet Remix Hot Thang 012021\Chẳng Thể Tìm Được Em (Orinn EDM Remix).txt',	N'D:\Images\Nghe gì hôm nay\Nhac Viet Remix Hot Thang 012021\Chẳng Thể Tìm Được Em (Orinn EDM Remix).jpg',	N'Chẳng Thể Tìm Được Em (Orinn EDM Remix)',	N'PhucXP',	N'Nhac Viet Remix Hot Thang 012021',	4,	N'Gym',	1,	N'Nhạc remix',3),
(N'D:\Song\Nghe gì hôm nay\Nhac Viet Remix Hot Thang 012021\Chung Ta Cua Hien Tai (ThienHi X HighFrequency Remix)  -  Son Tung M-TP.mp3',	N'D:\Lyrics\Nghe gì hôm nay\Nhac Viet Remix Hot Thang 012021\Chúng Ta Của Hiện Tại (ThienHi X HighFrequency Remix).txt',	N'D:\Images\Nghe gì hôm nay\Nhac Viet Remix Hot Thang 012021\Chúng Ta Của Hiện Tại (ThienHi X HighFrequency Remix).jpg',	N'Chúng Ta Của Hiện Tại (ThienHi X HighFrequency Remix)',	N'Sơn Tùng M-TP',	N'Nhac Viet Remix Hot Thang 012021',	4,	N'Giải trí',	4,	N'Nhạc trẻ',2),
(N'D:\Song\Nghe gì hôm nay\Nhac Viet Remix Hot Thang 012021\Dong Vua Sang Remix  -  Nhu Viet, ACV.mp3',	N'D:\Lyrics\Nghe gì hôm nay\Nhac Viet Remix Hot Thang 012021\Đông Vừa Sang Remix.txt',	N'D:\Images\Nghe gì hôm nay\Nhac Viet Remix Hot Thang 012021\Đông Vừa Sang Remix.jpg',	N'Đông Vừa Sang Remix',	N'Như Việt, ACV',	N'Nhac Viet Remix Hot Thang 012021',	4,	N'Thư giãn',	3,	N'Nhạc remix',3),
(N'D:\Song\Nghe gì hôm nay\Nhac Viet Remix Hot Thang 012021\Em Bang Qua (ACV Remix)  -  Lap Nguyen, ACV.mp3',	N'D:\Lyrics\Nghe gì hôm nay\Nhac Viet Remix Hot Thang 012021\Em Băng Qua (ACV Remix).txt',	N'D:\Images\Nghe gì hôm nay\Nhac Viet Remix Hot Thang 012021\Em Băng Qua (ACV Remix).jpg',	N'Em Băng Qua (ACV Remix)',	N'Lập Nguyên, ACV',	N'Nhac Viet Remix Hot Thang 012021',	4,	N'Giải trí',	4,	N'Nhạc remix',3),
(N'D:\Song\Nghe gì hôm nay\Nhac Viet Remix Hot Thang 012021\Em Bang Qua (Andy Remix)  -  Lap Nguyen, DJ Andy.mp3',	N'D:\Lyrics\Nghe gì hôm nay\Nhac Viet Remix Hot Thang 012021\Em Băng Qua (Andy Remix).txt',	N'D:\Images\Nghe gì hôm nay\Nhac Viet Remix Hot Thang 012021\Em Băng Qua (Andy Remix).jpg',	N'Em Băng Qua (Andy Remix)',	N'Lập Nguyên, DJ Andy',	N'Nhac Viet Remix Hot Thang 012021',	4,	N'Gym',	1,	N'Nhạc remix',3),
(N'D:\Song\Nghe gì hôm nay\Nhac Viet Remix Hot Thang 012021\Em Bang Qua (Orinn EDM Remix)  -  Lap Nguyen.mp3',	N'D:\Lyrics\Nghe gì hôm nay\Nhac Viet Remix Hot Thang 012021\Em Băng Qua (Orinn EDM Remix).txt',	N'D:\Images\Nghe gì hôm nay\Nhac Viet Remix Hot Thang 012021\Em Băng Qua (Orinn EDM Remix).jpg',	N'Em Băng Qua (Orinn EDM Remix)',	N'Lập Nguyên',	N'Nhac Viet Remix Hot Thang 012021',	4,	N'Giải trí',	4,	N'Nhạc trẻ',2),
(N'D:\Song\Nghe gì hôm nay\Nhac Viet Remix Hot Thang 012021\Hoa Chua Tan Tinh Da Tan (Orinn Remix)  -  NB3 Hoai Bao.mp3',	N'D:\Lyrics\Nghe gì hôm nay\Nhac Viet Remix Hot Thang 012021\Hoa Chưa Tàn Tình Đã Tan (Orinn Remix).txt',	N'D:\Images\Nghe gì hôm nay\Nhac Viet Remix Hot Thang 012021\Hoa Chưa Tàn Tình Đã Tan (Orinn Remix).jpg',	N'Hoa Chưa Tàn Tình Đã Tan (Orinn Remix)',	N'NB3 Hoài Bảo',	N'Nhac Viet Remix Hot Thang 012021',	4,	N'Thư giãn',	3,	N'Nhạc remix',3),
(N'D:\Song\Nghe gì hôm nay\Nhac Viet Remix Hot Thang 012021\Hom Nay Em Cuoi Roi (Orinn Vinahouse Remix)  -  Khai Dang.mp3',	N'D:\Lyrics\Nghe gì hôm nay\Nhac Viet Remix Hot Thang 012021\Hôm Nay Em Cưới Rồi (Orinn Vinahouse Remix).txt',	N'D:\Images\Nghe gì hôm nay\Nhac Viet Remix Hot Thang 012021\Hôm Nay Em Cưới Rồi (Orinn Vinahouse Remix).jpg',	N'Hôm Nay Em Cưới Rồi (Orinn Vinahouse Remix)',	N'Khải Đăng',	N'Nhac Viet Remix Hot Thang 012021',	4,	N'Giải trí',	4,	N'Nhạc trẻ',2),
(N'D:\Song\Nghe gì hôm nay\Nhac Viet Remix Hot Thang 012021\Khong Dang De Thuong (NDQ Remix)  -  Dinh Tung Huy.mp3',	N'D:\Lyrics\Nghe gì hôm nay\Nhac Viet Remix Hot Thang 012021\Không Đáng Để Thương (NĐQ Remix).txt',	N'D:\Images\Nghe gì hôm nay\Nhac Viet Remix Hot Thang 012021\Không Đáng Để Thương (NĐQ Remix).jpg',	N'Không Đáng Để Thương (NĐQ Remix)',	N'Đinh Tùng Huy',	N'Nhac Viet Remix Hot Thang 012021',	4,	N'Học Tập',	2,	N'Nhạc trẻ',2),
(N'D:\Song\Nghe gì hôm nay\Nhac Viet Remix Hot Thang 012021\Mac Cho Dung Sai (EDM)  -  Phuong Dang, ACV.mp3',	N'D:\Lyrics\Nghe gì hôm nay\Nhac Viet Remix Hot Thang 012021\Mặc Cho Đúng Sai (Edm).txt',	N'D:\Images\Nghe gì hôm nay\Nhac Viet Remix Hot Thang 012021\Mặc Cho Đúng Sai (Edm).jpg',	N'Mặc Cho Đúng Sai (Edm)',	N'Phương Đặng',	N'Nhac Viet Remix Hot Thang 012021',	4,	N'Giải trí',	4,	N'Nhạc remix',3),
(N'D:\Song\Nghe gì hôm nay\Nhac Viet Remix Hot Thang 012021\Ngoi Nha Hoa Hong - Moi Nguoi Mot Noi (BiBo Remix)  -  DJ Bibo.mp3',	N'D:\Lyrics\Nghe gì hôm nay\Nhac Viet Remix Hot Thang 012021\Ngôi Nhà Hoa Hồng - Mỗi Người Một Nơi (BiBo Remix).txt',	N'D:\Images\Nghe gì hôm nay\Nhac Viet Remix Hot Thang 012021\Ngôi Nhà Hoa Hồng - Mỗi Người Một Nơi (BiBo Remix).jpg',	N'Ngôi Nhà Hoa Hồng - Mỗi Người Một Nơi (BiBo Remix)',	N'DJ Bibo',	N'Nhac Viet Remix Hot Thang 012021',	4,	N'Học Tập',	2,	N'Nhạc remix',3),
(N'D:\Song\Nghe gì hôm nay\Nhac Viet Remix Hot Thang 012021\Niu Duyen (DJ Viet Anh Remix)  -  Le Bao Binh, DJ Viet Anh.mp3',	N'D:\Lyrics\Nghe gì hôm nay\Nhac Viet Remix Hot Thang 012021\Níu Duyên (DJ Việt Anh Remix).txt',	N'D:\Images\Nghe gì hôm nay\Nhac Viet Remix Hot Thang 012021\Níu Duyên (DJ Việt Anh Remix).jpg',	N'Níu Duyên (DJ Việt Anh Remix)',	N'Lê Bảo Bình, DJ Việt Anh',	N'Nhac Viet Remix Hot Thang 01202',	4,	N'Học Tập',	2,	N'Nhạc trẻ',2),
(N'D:\Song\Nghe gì hôm nay\Nhac Viet Remix Hot Thang 012021\Niu Duyen (Orinn Remix)  -  Le Bao Binh.mp3',	N'D:\Lyrics\Nghe gì hôm nay\Nhac Viet Remix Hot Thang 012021\Níu Duyên (Orinn Remix).txt',	N'D:\Images\Nghe gì hôm nay\Nhac Viet Remix Hot Thang 012021\Níu Duyên (Orinn Remix).jpg',	N'Níu Duyên (Orinn Remix)',	N'Lê Bảo Bình',	N'Nhac Viet Remix Hot Thang 012021',	4,	N'Giải trí',	4,	N'Nhạc remix',3),
(N'D:\Song\Nghe gì hôm nay\Nhac Viet Remix Hot Thang 012021\So Lam 2 (Orinn EDM Remix)  -  NB3 Hoai Bao, Freak D.mp3',	N'D:\Lyrics\Nghe gì hôm nay\Nhac Viet Remix Hot Thang 012021\Sợ Lắm 2 (Orinn EDM Remix).txt',	N'D:\Images\Nghe gì hôm nay\Nhac Viet Remix Hot Thang 012021\Sợ Lắm 2 (Orinn EDM Remix).jpg',	N'Sợ Lắm 2 (Orinn EDM Remix)',	N'NB3 Hoài Bảo, Freak D',	N'Nhac Viet Remix Hot Thang 012021',	4,	N'Giải trí',	4,	N'Nhạc remix',3),
(N'D:\Song\Nghe gì hôm nay\Nhac Viet Remix Hot Thang 012021\The Thai (Htrol Remix)  -  Huong Ly.mp3',	N'D:\Lyrics\Nghe gì hôm nay\Nhac Viet Remix Hot Thang 012021\Thế Thái (Htrol Remix).txt',	N'D:\Images\Nghe gì hôm nay\Nhac Viet Remix Hot Thang 012021\Thế Thái (Htrol Remix).jpg',	N'Thế Thái (Htrol Remix)',	N'Hương Ly',	N'Nhac Viet Remix Hot Thang 012021',	4,	N'Thư giãn',	3,	N'Nhạc trẻ',3),
(N'D:\Song\Nghe gì hôm nay\Nhac Viet Remix Hot Thang 012021\Tinh Yeu Khung Long (Dai Meo Remix)  -  FAY.mp3',	N'D:\Lyrics\Nghe gì hôm nay\Nhac Viet Remix Hot Thang 012021\Tình Yêu Khủng Long (Đại Mèo Remix).txt',	N'D:\Images\Nghe gì hôm nay\Nhac Viet Remix Hot Thang 012021\Tình Yêu Khủng Long (Đại Mèo Remix).jpg',	N'Tình Yêu Khủng Long (Đại Mèo Remix)',	N'FAY',	N'Nhac Viet Remix Hot Thang 012021',	4,	N'Gym',	1,	N'Nhạc trẻ',3),
(N'D:\Song\Nghe gì hôm nay\Nhac Viet Remix Hot Thang 012021\Tren Tinh Ban Duoi Tinh Yeu (Phong Max Remix) Cover  -  Nguyet.mp3',	N'D:\Lyrics\Nghe gì hôm nay\Nhac Viet Remix Hot Thang 012021\Trên Tình Bạn Dưới Tình Yêu (Phong Max Remix) Cover.txt',	N'D:\Images\Nghe gì hôm nay\Nhac Viet Remix Hot Thang 012021\Trên Tình Bạn Dưới Tình Yêu (Phong Max Remix) Cover.jpg',	N'Trên Tình Bạn Dưới Tình Yêu (Phong Max Remix) Cover',	N'Nguyệt',	N'Nhac Viet Remix Hot Thang 012021',	4,	N'Giải trí',	4,	N'Nhạc remix',3),
(N'D:\Song\Nghe gì hôm nay\Nhac Viet Remix Hot Thang 012021\Ve Voi Anh Di (Orinn Remix)  -  Nguyen Quang Quy.mp3',	N'D:\Lyrics\Nghe gì hôm nay\Nhac Viet Remix Hot Thang 012021\Về Với Anh Đi (Orinn Remix).txt',	N'D:\Images\Nghe gì hôm nay\Nhac Viet Remix Hot Thang 012021\Về Với Anh Đi (Orinn Remix).jpg',	N'Về Với Anh Đi (Orinn Remix)',	N'Nguyễn Quang Quý',	N'Nhac Viet Remix Hot Thang 012021',	4,	N'Gym',	1,	N'Nhạc remix',3);
go
--SET IDENTITY_INSERT dbo.song OFF

insert into dbo.song (song_path, lyric_path, image_path, name, singer ,	name_album, id_album, name_playlist, id_playlist, song_type, song_type_id)
values
(N'D:\Song\Mới phát hành\ChiLaLuaDoi-ChiThien-6897277.mp3',	N'D:\Lyrics\Mới phát hành\Chỉ Là Lừa Dối.txt',	N'D:\Images\Mới phát hành\Chỉ Là Lừa Dối.jpg',	N'Chỉ Là Lừa Dối',	N'Chí Thiện',	N'None',	5,	N'Học Tập',	2,	N'Nhạc trẻ',	2),
(N'D:\Song\Mới phát hành\DeToiNgoiHatMotMinh-ThaiTuyetTram-6892712.mp3',	N'D:\Lyrics\Mới phát hành\Để Tôi Ngồi Hát Một Mình.txt',	N'D:\Images\Mới phát hành\Để Tôi Ngồi Hát Một Mình.png',	N'Để Tôi Ngồi Hát Một Mình',	N'Thái Tuyết Trâm',	N'None',	5,	N'Học Tập',	2,	N'Nhạc trẻ',	2),
(N'D:\Song\Mới phát hành\DoiVuiLamEmOi-X2X-6893322.mp3',	N'D:\Lyrics\Mới phát hành\Đời Vui Lắm Em Ơi.txt',	N'D:\Images\Mới phát hành\Đời Vui Lắm Em Ơi.jpg',	N'Đời Vui Lắm Em Ơi',	N'X2X',	N'None', 5,	N'Thư giãn',	3,	N'Nhạc trẻ',	2),
(N'D:\Song\Mới phát hành\InMe-NangMinhNhut-6889294.mp3',	N'D:\Lyrics\Mới phát hành\In Me.txt',	N'D:\Images\Mới phát hành\In Me.jpg',	N'In Me',	N'Nắng (Minh Nhựt)',	N'None',	5,	N'Thư giãn',	3,	N'Nhạc trẻ',	2),
(N'D:\Song\Mới phát hành\NiuDuyen-LeBaoBinh-6872127.mp3',	N'D:\Lyrics\Mới phát hành\Níu Duyên.txt',	N'D:\Images\Mới phát hành\Níu Duyên.jpg',	N'Níu Duyên',	N'Lê Bảo Bình',	N'None',	5,	N'Học Tập',	2,	N'Nhạc trẻ',	2),
(N'D:\Song\Mới phát hành\NoiNho-ToNgocHa-6896921.mp3',	N'D:\Lyrics\Mới phát hành\Nỗi Nhớ.txt',	N'D:\Images\Mới phát hành\Nỗi Nhớ.jpg',	N'Nỗi Nhớ',	N'Tô Ngọc Hà',	N'None',	5,	N'Thư giãn',	3,	N'Nhạc trẻ',	2),
(N'D:\Song\Mới phát hành\ThuongAnh-TrangYueBRay-6895235.mp3', N'D:\Lyrics\Mới phát hành\Thương Anh.txt',	N'D:\Images\Mới phát hành\Thương Anh.jpg',	N'Thương Anh',	N'Trang Yue, B Ray',	N'None',	5,	N'Thư giãn',	3,	N'Nhạc trẻ', 2),
(N'D:\Song\Mới phát hành\YeuDungSoDau-NgoLanHuong-6898216.mp3',	N'D:\Lyrics\Mới phát hành\Yêu Đừng Sợ Đau.txt',	N'D:\Images\Mới phát hành\Yêu Đừng Sợ Đau.jpg',	N'Yêu Đừng Sợ Đau',	N'Ngô Lan Hương',	N'None',	5,	N'Học Tập',	2,	N'Nhạc trẻ',	2);


-----------------------------------

--lọc bài hát theo id album
select * from song where song.id_album=1
--1 ở đây là id album
--lọc bài hát theo tên album
select * from song where song.name_album=N'EDM Best Remixes'
--N'EDM Best Remixes' là tên album N ở phía trước để định dạng tiếng Việt
--lọc bài hát theo id playlist 
select * from song where song.id_playlist = 2
--2 ở đây là id playlist
--lọc bài hát theo tên playlist 
select * from song where song.name_playlist = N'Giải trí'
--N'Giải trí' ở đây là tên playlist

--Lọc theo thể loại làm tương tự như trên
-- Với album=None tức là nằm trong mục Mới phát hành

--Thể loại:
-- Coffee Weekend: id=1, Doi Minh Di Ben Nhau - Playlist Danh Cho Du Lich: id=2, 
--EDM Best Remixes: id=3, Nhac Viet Remix Hot Thang 012021: id=4, None: id=5

--Playlist:
--Gym: id=1, Học Tập: id=2, Thư giãn: id=3, Giải trí: id=4

--Thể loại:
--Nhạc nước ngoài: id=1, Nhạc trẻ: id=2, Nhạc remix: id=3

--Lưu ý các đường dẫn nếu không load được file nhạc, lyric hay hình ảnh

create table video
(
	id int identity (1,1) primary key,
	video_path nvarchar(300) not null,
	--lyric_path nvarchar(300) not null,
	image_path nvarchar(300) not null,
	name nvarchar(100) not null,
	singer nvarchar(100),
	--name_album nvarchar(200),
	--id_album int,
	--name_playlist nvarchar(200),
	--id_playlist int,
	song_type nvarchar(100),
	song_type_id int,	
)

insert into dbo.video (video_path, image_path, name, singer, song_type, song_type_id)
values 
(N'D:\Videos\Videos\(Karaoke) Đi về nhà - Đen & Justatee - Beat Chuẩn.mp4',N'D:\Videos\Images of video\(Karaoke) Đi về nhà - Đen & Justatee - Beat Chuẩn.jpg',N'(Karaoke) Đi về nhà - Đen & Justatee - Beat Chuẩn',N'Đen & Justatee', N'Nhạc trẻ', 2),
(N'D:\Videos\Videos\Con Cò Bé Bé Karaoke Nhạc Thiếu Nhi Hay - Karaoke Con Cò Bé Bé.mp4',N'D:\Videos\Images of video\Con Cò Bé Bé Karaoke Nhạc Thiếu Nhi Hay - Karaoke Con Cò Bé Bé.jpg',N'Con Cò Bé Bé Karaoke Nhạc Thiếu Nhi Hay - Karaoke Con Cò Bé Bé', N'Xuân Mai',N'Nhạc trẻ', 2),
(N'D:\Videos\Videos\Happy New Year - Abba - Karaoke.mp4',N'D:\Videos\Images of video\Happy New Year - Abba - Karaoke.jpg',N'Happy New Year - Abba - Karaoke', N'Abba', N'Nhạc nước ngoài', 1),
(N'D:\Videos\Videos\Karaoke - CỐ GIANG TÌNH - New Rap (Ballad Version) - Phát Hồ x JokeS Bii.mp4',N'D:\Videos\Images of video\Karaoke - CỐ GIANG TÌNH - New Rap (Ballad Version) - Phát Hồ x JokeS Bii.jpg',N'Karaoke - CỐ GIANG TÌNH - New Rap (Ballad Version) - Phát Hồ x JokeS Bii', N'Phát Hồ x JokeS Bii', N'Nhạc trẻ', 2),
(N'D:\Videos\Videos\Karaoke - Trúc Xinh (Ciray Remix) - Minh Vương M4U ft. Việt - Beat Remix.mp4',N'D:\Videos\Images of video\Karaoke - Trúc Xinh (Ciray Remix) - Minh Vương M4U ft. Việt - Beat Remix.jpg',N'Karaoke - Trúc Xinh (Ciray Remix) - Minh Vương M4U ft. Việt - Beat Remix',N'Minh Vương M4U ft. Việt', N'Nhạc remix', 3),
(N'D:\Videos\Videos\KARAOKE - Vợ Ơi - Lê Bảo Bình.mp4',N'D:\Videos\Images of video\KARAOKE - Vợ Ơi - Lê Bảo Bình.jpg',N'KARAOKE - Vợ Ơi - Lê Bảo Bình', N'Lê Bảo Bình',N'Nhạc trẻ', 2),
(N'D:\Videos\Videos\Karaoke Anh Từng Cố Gắng - Nhật Phong (Beat Gốc).mp4',N'D:\Videos\Images of video\Karaoke Anh Từng Cố Gắng - Nhật Phong (Beat Gốc).jpg',N'Karaoke Anh Từng Cố Gắng - Nhật Phong (Beat Gốc)', N'Nhật Phong', N'Nhạc trẻ', 2),
(N'D:\Videos\Videos\Karaoke Thế thái _ X2X (New Version) _ Có rap.mp4',N'D:\Videos\Images of video\Karaoke Thế thái _ X2X (New Version) _ Có rap.jpg',N'Karaoke Thế thái _ X2X (New Version) _ Có rap', N'X2X', N'Nhạc remix', 3),
(N'D:\Videos\Videos\Shape of You - Ed Sheeran Karaoke .mp4',N'D:\Videos\Images of video\Shape of You - Ed Sheeran Karaoke.jpg',N'Shape of You - Ed Sheeran Karaoke ', N'Ed Sheen', N'Nhạc nước ngoài', 1),
(N'D:\Videos\Videos\Something Just Like This - The Chainsmokers & Coldplay Karaoke.mp4',N'D:\Videos\Images of video\Something Just Like This - The Chainsmokers & Coldplay Karaoke.jpg',N'Something Just Like This - The Chainsmokers & Coldplay Karaoke', N'The Chainsmokers & Coldplay',N'Nhạc nước ngoài', 1 ),
(N'D:\Videos\Videos\SÓNG GIÓ KARAOKE - JACK x K-ICM [Official Video].mp4',N'D:\Videos\Images of video\SÓNG GIÓ KARAOKE - JACK x K-ICM [Official Video].jpg',N'SÓNG GIÓ KARAOKE - JACK x K-ICM [Official Video]', N'JACK x K-ICM', N'Nhạc trẻ', 2),
(N'D:\Videos\Videos\[ Karaoke Remix ] Em Băng Qua - Lập Nguyên (T-Epic Remix) - Deep House.mp4',N'D:\Videos\Images of video\[ Karaoke Remix ] Em Băng Qua - Lập Nguyên (T-Epic Remix) - Deep House.jpg',N'[ Karaoke Remix ] Em Băng Qua - Lập Nguyên (T-Epic Remix) - Deep House', N'Lập Nguyên', N'Nhạc remix', 3),
(N'D:\Videos\Videos\[KARAOKE BEAT] AI MANG CÔ ĐƠN ĐI - K-ICM FT. APJ - ICM STUDIO.mp4',N'D:\Videos\Images of video\[KARAOKE BEAT] AI MANG CÔ ĐƠN ĐI - K-ICM FT. APJ - ICM STUDIO.jpg',N'[KARAOKE BEAT] AI MANG CÔ ĐƠN ĐI - K-ICM FT. APJ - ICM STUDIO', N'K-ICM FT. APJ - ICM STUDIO', N'Nhạc trẻ', 2),
(N'D:\Videos\Videos\[Karaoke-Beat] Níu Duyên - Lê Bảo Bình - Tone Nữ.mp4',N'D:\Videos\Images of video\[Karaoke-Beat] Níu Duyên - Lê Bảo Bình - Tone Nữ.jpg',N'[Karaoke-Beat] Níu Duyên - Lê Bảo Bình - Tone Nữ', N'Lê Bảo Bình',  N'Nhạc trẻ', 2),
(N'D:\Videos\Videos\[Karaoke] Tình Sầu Thiên Thu Muôn Lối - Doãn Hiếu l Beat Chuẩn Không Bè.mp4',N'D:\Videos\Images of video\[Karaoke] Tình Sầu Thiên Thu Muôn Lối - Doãn Hiếu l Beat Chuẩn Không Bè.jpg',N'[Karaoke] Tình Sầu Thiên Thu Muôn Lối - Doãn Hiếu l Beat Chuẩn Không Bè', N'Doãn Hiếu', N'Nhạc remix', 3)



select * from dbo.song where song_type = N'nhạc trẻ'

