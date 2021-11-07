import React, { useState, useEffect } from "react";
import Post from "../Post";

function Mainsection() {
    const [posts, setPosts] = useState([]);
    useEffect(() => {
        fetching();
    }, []);
    console.log(posts);
    function fetching() {
        fetch("https://jsonplaceholder.typicode.com/posts")
            .then((res) => res.json())
            .then((res) => setPosts(res));
    }
    return (
        <div>
            {posts.map((post) => {
                return <Post post={post} />;
            })}
        </div>
    );
}

export default Mainsection;
