import React from "react";
import Card from "@mui/material/Card";
import CardContent from "@mui/material/CardContent";
import CardMedia from "@mui/material/CardMedia";
import Typography from "@mui/material/Typography";
import { CardActionArea } from "@mui/material";
function CapsCard({ caps }) {
    return (
        <Card sx={{ maxWidth: 345, minHeight: 250 }}>
            <CardActionArea>
                <CardMedia
                    component="img"
                    height="140"
                    image={caps.url}
                    alt="green iguana"
                />
                <CardContent>
                    <Typography
                        gutterBottom
                        variant="h5"
                        component="div"
                        overflow="hidden"
                    >
                        {caps.name}
                    </Typography>
                </CardContent>
            </CardActionArea>
        </Card>
    );
}

export default CapsCard;
