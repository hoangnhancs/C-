
from os import listdir
from os.path import isfile, join
from tinytag import TinyTag as T
"""
folder = str("E:\\Song\\Nghe gì hôm nay")

#onlyfile = [f for f in listdir(mypath) if isfile(join(mypath, f))]
#print(mypath + onlyfile[0])




tag = eyeD3.Tag()
tag.link("/some/file.mp3")
print(tag.getArtist())
print(tag.getAlbum())
print(tag.getTitle())


audio = T.get(mypath + "\\" + onlyfile[0])

print("Title:" + audio.title) 
print("Artist: " + audio.artist) 
print("Genre:" + audio.genre) 
print("Year Released: " + audio.year) 
print("Bitrate:" + str(audio.bitrate) + " kBits/s") 
"""
"""
#print("Composer: " + audio.composer) 

_id = []
song_path = []
name = []
singer = []
lyrics_path = []
images_path = []
album = []

from pandas import DataFrame

for _ in listdir(folder):
    mypath = folder + "\\" +  _
    #print(mypath)
    #onlyfile = [f for f in listdir(mypath) if isfile(join(mypath, f))]
    i = 0
    for f in listdir(mypath):
        if isfile(join(mypath, f)):
            i+=1
            _id.append(i)
            song_path.append(join(mypath, f))
            audio = T.get(song_path[-1])
            name.append(audio.title)
            singer.append(audio.artist)
            album.append(_)

lyrics_folder = str("E:\\Lyrics\\Nghe gì hôm nay")
for _ in listdir(lyrics_folder):
    mypath = lyrics_folder + "\\" +  _
    for f in listdir(mypath):
        if isfile(join(mypath, f)):
            lyrics_path.append(join(mypath, f))

images_folder = str("E:\\Images\\Nghe gì hôm nay")
for _ in listdir(images_folder):
    mypath = images_folder + "\\" +  _
    for f in listdir(mypath):
        if isfile(join(mypath, f)):
            images_path.append(join(mypath, f))

C = {'ID': _id,
    'Song path': song_path,
    'Lyrics path': lyrics_path,
    'Images path': images_path,
    'Name': name,
    'Singer': singer,
    'Album' : album,
    }
df = DataFrame(C, columns= ['ID', 'Song path', 'Lyrics path', 'Images path', 'Name', 'Singer', 'Album'])
export_csv = df.to_csv (r'E:\hoangnhancs\C-\song_infor.csv', index = None, header=True, encoding="utf-8") # here you have to write path, where result file will be stored
print (df)
"""



_id = []
song_path = []
name = []
singer = []
lyrics_path = []
images_path = []
album = []

from pandas import DataFrame
mypath = str("E:\\Song\\Mới phát hành")
i = 0
for f in listdir(mypath):
    if isfile(join(mypath, f)):
        i+=1
        _id.append(i)
        song_path.append(join(mypath, f))
        audio = T.get(song_path[-1])
        name.append(audio.title)
        singer.append(audio.artist)
        album.append("None")

lyrics_folder = str("E:\\Lyrics\\Mới phát hành")
for f in listdir(lyrics_folder):
    #print(f)
    if isfile(join(lyrics_folder, f)):
        lyrics_path.append(join(lyrics_folder, f))

images_folder = str("E:\\Images\\Mới phát hành")
for f in listdir(images_folder):
    #print(f)
    if isfile(join(images_folder, f)):
        images_path.append(join(images_folder, f))


#print((lyrics_path))
#print(images_path)



C = {'ID': _id,
    'Song path': song_path,
    'Lyrics path': lyrics_path,
    'Images path': images_path,
    'Name': name,
    'Singer': singer,
    'Album' : album,
    }

df = DataFrame(C, columns= ['ID', 'Song path', 'Lyrics path', 'Images path', 'Name', 'Singer', 'Album'])
export_csv = df.to_csv (r'E:\hoangnhancs\C-\moi_phat_hanh_infor.csv', index = None, header=True, encoding="utf-8") # here you have to write path, where result file will be stored
print (df)



