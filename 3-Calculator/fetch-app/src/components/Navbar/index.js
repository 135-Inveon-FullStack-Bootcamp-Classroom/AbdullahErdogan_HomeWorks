import React from "react";
import "./style.css";
function Navbar() {
    return (
        <div>
            <ul className="navbar">
                <li>
                    <a className="logoLink">
                        <img
                            className="logo"
                            src="https://cdn-icons-png.flaticon.com/512/1691/1691121.png"
                        />
                        <span className="tuzlu">tuzlu</span>sözlük
                    </a>
                </li>
                <li>
                    <input
                        className="searchInput"
                        placeholder="search anything..."
                    />
                </li>
            </ul>
        </div>
    );
}

export default Navbar;
