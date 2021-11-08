import React, { useEffect } from "react";
import Layout from "../Layout";
import Grid from "@mui/material/Grid";
import { useCapsContext } from "../../context/CapsContext";
import CapsCard from "../CapsCard";
function CapsList() {
    const { capsList, setCapsList } = useCapsContext();
    useEffect(() => {
        fetch("https://api.imgflip.com/get_memes")
            .then((res) => res.json())
            .then((res) => setCapsList(res.data.memes));
    }, []);
    if (!capsList) {
        return <div>Loading...</div>;
    }
    return (
        <Layout>
            <Grid
                container
                spacing={{ xs: 2, md: 3 }}
                columns={{ xs: 4, sm: 8, md: 12 }}
            >
                {capsList.map((caps, index) => (
                    <Grid item xs={2} sm={4} md={4} key={index}>
                        <CapsCard caps={caps} />
                    </Grid>
                ))}
            </Grid>
        </Layout>
    );
}

export default CapsList;
