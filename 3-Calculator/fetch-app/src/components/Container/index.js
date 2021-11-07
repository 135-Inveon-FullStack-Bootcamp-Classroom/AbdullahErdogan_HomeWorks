import React from "react";
import Mainsection from "../Mainsection";
import Sidebar from "../Sidebar";
import "./style.css";
function Container() {
    return (
        <div className="container">
            <div className="sidebar">
                <Sidebar />
            </div>
            <div className="mainSection">
                <Mainsection />
            </div>
        </div>
    );
}

export default Container;
