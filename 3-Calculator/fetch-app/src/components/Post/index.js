import React, { useState } from "react";
import "./stye.css";
import { BrowserRouter as Router, Route, Link, Routes } from "react-router-dom";
import PostById from "../PostById";
function Post({ post }) {
    const [open, setOpen] = useState(false);
    return (
        <div className="postArea">
            <Router>
                <Link to="/post" onClick={() => setOpen(!open)}>
                    {post.title}
                </Link>
                <div className="postBody">{post.body}</div>
                <Routes>
                    <Route
                        path="/post"
                        element={open ? <PostById postId={post.id} /> : ""}
                    ></Route>
                </Routes>
            </Router>
        </div>
    );
}

export default Post;
