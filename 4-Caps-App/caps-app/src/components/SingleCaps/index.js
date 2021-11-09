import React from "react";
import { useParams } from "react-router";
import Layout from "../Layout";
import { useCapsContext } from "../../context/CapsContext";
import { Button, Grid, TextField } from "@mui/material";
import { useFormik } from "formik";
function SingleCaps() {
    const { id } = useParams();
    const { getMemeById, setGeneratedMeme, generatedMeme } = useCapsContext();
    const meme = getMemeById(id);
    const formik = useFormik({
        initialValues: {
            firstText: "",
            secondText: "",
        },
        onSubmit: ({ firstText, secondText }) => {
            const url = `https://api.imgflip.com/caption_image?template_id=${id}&username=abdullaherdogan&password=abdullah1.&text0=${firstText}&text1=${secondText}`;
            fetch(url)
                .then((res) => res.json())
                .then((res) => setGeneratedMeme(res.data.url));
        },
    });
    return (
        <Layout>
            <form onSubmit={formik.handleSubmit}>
                <Grid container spacing={2}>
                    <Grid item xs={6}>
                        <img style={{ width: "100%" }} src={meme.url} />
                        {generatedMeme && (
                            <img
                                style={{ width: "100%" }}
                                src={generatedMeme}
                            />
                        )}
                    </Grid>
                    <Grid item xs={6}>
                        <TextField
                            sx={{ width: "100%" }}
                            variant="outlined"
                            label="First Text Area"
                            id="firstText"
                            onChange={formik.handleChange}
                            value={formik.values.firstText}
                        />
                        <TextField
                            sx={{ width: "100%" }}
                            variant="outlined"
                            id="secondText"
                            label="Second Text Area"
                            onChange={formik.handleChange}
                            value={formik.values.secondText}
                        />
                        <Button type="submit">Generate Meme</Button>
                    </Grid>
                </Grid>
            </form>
        </Layout>
    );
}

export default SingleCaps;
