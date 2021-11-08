import React from "react";
import ReactDOM from "react-dom";
import "./index.css";
import App from "./App";
import reportWebVitals from "./reportWebVitals";
import CssBaseLine from "@mui/material/CssBaseline";
ReactDOM.render(
    <React.StrictMode>
        <CssBaseLine />
        <App />
    </React.StrictMode>,
    document.getElementById("root")
);

reportWebVitals();
