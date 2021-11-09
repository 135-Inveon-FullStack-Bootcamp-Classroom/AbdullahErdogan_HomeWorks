import React from "react";
import { useParams } from "react-router";
import Layout from "../Layout";
import { useCapsContext } from "../../context/CapsContext";
import { Grid, TextField } from "@mui/material";
function SingleCaps() {
    const { id } = useParams();
    const { getMemeById } = useCapsContext();
    const meme = getMemeById(id);
    return (
        <Layout>
            <Grid container spacing={2}>
                <Grid item xs={6}>
                    <img style={{ width: "100%" }} src={meme.url} />
                </Grid>
                <Grid item xs={6}>
                    <TextField variant="outlined" label="First Text Area" />
                    <TextField variant="outlined" label="Second Text Area" />
                </Grid>
            </Grid>
        </Layout>
    );
}

export default SingleCaps;
