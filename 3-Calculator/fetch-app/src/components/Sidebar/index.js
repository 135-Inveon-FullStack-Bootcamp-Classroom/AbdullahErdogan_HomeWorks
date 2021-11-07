import React from "react";
import "./style.css";
function Sidebar() {
    return (
        <div>
            <ul className="sidebarList">
                <li>
                    <a className="listItem" href="#">
                        Gündem
                    </a>
                </li>
                <li>
                    <a className="listItem" href="#">
                        Siyaset
                    </a>
                </li>
                <li>
                    <a className="listItem" href="#">
                        Türkiye
                    </a>
                </li>
                <li>
                    <a className="listItem" href="#">
                        Tuhaflıklar
                    </a>
                </li>
                <li>
                    <a className="listItem" href="#">
                        Gündem
                    </a>
                </li>
            </ul>
        </div>
    );
}

export default Sidebar;
