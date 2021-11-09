import React, { useEffect } from "react";
import Layout from "../Layout";
import Grid from "@mui/material/Grid";
import { useCapsContext } from "../../context/CapsContext";
import CapsCard from "../CapsCard";
import { Link } from "react-router-dom";
function CapsList() {
    const { capsList, setGeneratedMeme } = useCapsContext();
    useEffect(() => {
        setGeneratedMeme("");
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
                        <Link to={`/single-caps/${caps.id}`}>
                            <CapsCard caps={caps} />
                        </Link>
                    </Grid>
                ))}
            </Grid>
        </Layout>
    );
}

export default CapsList;
