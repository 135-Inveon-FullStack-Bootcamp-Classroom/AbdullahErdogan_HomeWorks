import React from "react";
import AppBar from "@mui/material/AppBar";
import Typography from "@mui/material/Typography";
import { Toolbar } from "@mui/material";
function Header() {
    return (
        <AppBar position="static">
            <Toolbar>
                <Typography variant="h4" fontWeight="bold" padding="normal">
                    Meme Generator
                </Typography>
            </Toolbar>
        </AppBar>
    );
}

export default Header;
