
from os import listdir
from os.path import isfile, join
from tinytag import TinyTag as T
from pandas import DataFrame
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

"""
# _id = []
# video_path = []
# singer = []
# name = []
# i = 0
# videos_folder = "E:\\Videos\\Videos"
# for f in listdir(videos_folder):
#     if isfile(join(videos_folder, f)):
#         i += 1
#         #print(join(videos_folder, f))
#         path = join(videos_folder, f)
#         _id.append(i)
#         video_path.append(path)
#         #audio = T.get(video_path[-1])
#         name.append(path.split("\\")[-1].split(".mp4")[0])
#         #print(path.split("\\"))
#         #singer.append(audio.artist)

# #E:\Videos\Images of video
# img_video_path = []
# img_videos_folder = "E:\\Videos\\Images of video"
# for f in listdir(img_videos_folder):
#     if isfile(join(img_videos_folder, f)):
        
#         #print(join(videos_folder, f))
#         path = join(img_videos_folder, f)
#         #_id.append(i)
#         #video_path.append(path)
#         #audio = T.get(video_path[-1])
#         img_video_path.append(path)
#         #print(path.split("\\"))
#         #singer.append(audio.artist)

# #print(_id)
# #print(name)
# #print(name)
# #print(singer)

# C = {'ID': _id,
#     'Video path': video_path,
#     #'Lyrics path': lyrics_path,
#     'Image path': img_video_path,
#     'Name': name,
#     #'Singer': singer,
#     #'Album' : album,
#     }

# df = DataFrame(C, columns= ['ID', 'Video path','Image path', 'Name'])
# export_csv = df.to_csv (r'E:\\hoangnhancs\\C-\\video_infor.csv', index = None, header=True, encoding="utf-8") # here you have to write path, where result file will be stored
# print (df)

# for i in range(len(_id)):
#     print("(N'"+video_path[i]+"',N'"+img_video_path[i]+"',N'"+name[i]+"')")
######################################################################################
# path = "E:\\new_song"
# title = []
# song_path = []
# for f in listdir(path):
#     if isfile(join(path, f)):
        
#         #print(join(videos_folder, f))
#         _path = join(path, f)
#         #_id.append(i)
#         #video_path.append(path)
#         audio = T.get(_path)
#         #print(audio.title)
#         title.append(audio.title)
#         song_path.append(_path)
#         #print(path.split("\\"))
#         #singer.append(audio.artist)
# image_path =[]
# path = "E:\\new_image"
# for f in listdir(path):
#     if isfile(join(path, f)):
        
#         #print(join(videos_folder, f))
#         _path = join(path, f)
#         #_id.append(i)
#         #video_path.append(path)
#         #audio = T.get(_path)
#         #print(audio.title)
#         #title.append(audio.title)
#         #print(path.split("\\"))
#         #singer.append(audio.artist)
#         image_path.append(_path)
# lyric_path =[]
# path = "E:\\new_lyric"
# for f in listdir(path):
#     if isfile(join(path, f)):
        
#         #print(join(videos_folder, f))
#         _path = join(path, f)
#         #_id.append(i)
#         #video_path.append(path)
#         #audio = T.get(_path)
#         #print(audio.title)
#         #title.append(audio.title)
#         #print(path.split("\\"))
#         #singer.append(audio.artist)
#         lyric_path.append(_path)

# for i in range (len(title)):
#     print("(N'"+song_path[i]+"',N'"+lyric_path[i]+"',N'"+image_path[i]+"',N'"+title[i]+"',N'Lê Bảo Bình', N'None', 5, N'Thư giãn', 3, N'Nhạc trẻ', 2)")

#--------------------------------------------------------------
path = "E:\\pll_and_al_image"

for f in listdir(path):
    if isfile(join(path, f)):
        
        #print(join(videos_folder, f))
        _path = join(path, f)
        #_id.append(i)
        #video_path.append(path)
        #audio = T.get(_path)
        #print(audio.title)
        #title.append(audio.title)
        #print(path.split("\\"))
        #singer.append(audio.artist)
        print(_path)
