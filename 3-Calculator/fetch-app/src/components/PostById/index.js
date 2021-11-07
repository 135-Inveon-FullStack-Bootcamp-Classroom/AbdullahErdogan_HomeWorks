import React, { useState, useEffect } from "react";
import "./style.css";
function PostById({ postId }) {
    const [comments, setComments] = useState([]);
    useEffect(() => {
        getPost();
    }, []);
    function getPost() {
        fetch(`https://jsonplaceholder.typicode.com/posts/${postId}/comments`)
            .then((res) => res.json())
            .then((res) => setComments(res));
    }
    return (
        <div className="commentArea">
            {comments.map((comment) => {
                return (
                    <div className="commnentContainer">
                        <div className="userName">{comment.name}</div>
                        <div className="comment">{comment.body}</div>
                    </div>
                );
            })}
        </div>
    );
}

export default PostById;
