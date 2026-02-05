
Design

Program
   └── Main()

Video
   ├── _title
   ├── _author
   ├── _length
   ├── _commentsList (List<Comment>)
   ├── _videoList (List<Video>)
   └── Methods: GetTitle, SetTitle, GetAuthor, SetAuthor, GetLength, SetLength, //Getters and Setters
                AddCommentToList, DisplayVideoInfo, GetNumberOfComments

Comment
   ├── _name
   ├── _text
   └── Methods: DisplayCommentInfo


Responsibilities

* Program
    - Displays an intro message. 
    - Creates several Video objects. 
    - Sets each video’s title, author, length.
    - Adds comments to each video. 
    - Stores all videos inside a videoManager object. 
    - Iterates through the list of videos and calls DisplayVideoInfo() to show details.

* Video
    - Store video metadata. 
    - Add comments (AddCommentToList()).
    - Display video info (DisplayVideoInfo()), including:
        - Title, author, length.
        - Number of comments.
        - Each comment’s info.

* Comments
    - Store comment data.
    - Display comment info (DisplayCommentInfo()).


