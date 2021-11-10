import React from "react";
import ReactDOM from "react-dom";
import "./index.css";
import App from "./App";
import reportWebVitals from "./reportWebVitals";
import CssBaseLine from "@mui/material/CssBaseline";
import { Provider } from "react-redux";
import Store from "./store";
ReactDOM.render(
    <React.StrictMode>
        <CssBaseLine />
        <Provider store={Store}>
            <App />
        </Provider>
    </React.StrictMode>,
    document.getElementById("root")
);

reportWebVitals();
